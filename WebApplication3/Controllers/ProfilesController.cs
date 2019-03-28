using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http;

namespace WebApplication3.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfilesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Get, filter and sort profiles
        public async Task<IActionResult> Index(string order, string searchString, bool useless)
        {
            string page = HttpContext.Request.Query["page"].ToString();
            var profiles = from m in _context.Profile select m;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (!String.IsNullOrEmpty(searchString))
            {
                profiles = profiles.Where(s => s.UserName.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(order))
            {
                if (order == "New")
                    profiles = profiles.OrderByDescending(s => s.CreationDate);
                else if (order == "Old")
                    profiles = profiles.OrderBy(s => s.CreationDate);
                else if (order == "Most")
                    profiles = profiles.OrderByDescending(s => s.Followers);
                else if (order == "Least")
                    profiles = profiles.OrderBy(s => s.Followers);
            }
            else
            {
                profiles = profiles.OrderByDescending(s => s.CreationDate);
            }

            if (user != null)
            {
                if (user.ProfileId > 0)
                {
                    var userProfileId = user.GetProfileId();
                    int i = 0;

                    foreach (var profile in profiles)
                    {
                        var check = await _context.FollowerList.FindAsync(profile.Id, userProfileId);
                        ViewData["isFollowing" + i.ToString()] = FollowedByUser(check, userProfileId);
                        i++;
                    }
                }
            }
            return View(await profiles.ToListAsync()); 
        }

        public string FollowedByUser(FollowerList check, int userProfileId)
        {
            string isFollowing = "no";

            if (check == null)
                isFollowing = "no";
            else if (check.FollowerId == userProfileId)
                isFollowing = "yes";

            return isFollowing;
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profile
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }
        
        public async Task<IActionResult> Create()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var userProfileId = user.GetProfileId();

            if (User.Identity.IsAuthenticated)
            {
                if (userProfileId == 0)
                    return View();
                else
                    return View("ProfileAlreadyCreated");
            }
            else
            {
                return View("LoginRedirect");
            }
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OwnerId,UserName,QuickDescription,Biography")] Profile profile)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (ModelState.IsValid)
            {
                profile.CreationDate = DateTime.Now;
                profile.SetOwnerId(userId); 
                _context.Add(profile);
                await _context.SaveChangesAsync();
                var recentlyAddedProfile = await _context.Profile.FirstOrDefaultAsync(m => m.OwnerId == userId);
                var profileId = recentlyAddedProfile.GetProfileId();
                user.SetProfileId(profileId); 
                await _context.SaveChangesAsync(); 
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profile.FindAsync(id);
            if (profile == null)
            {
                return NotFound();
            }
            return View(profile);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OwnerId,UserName,QuickDescription,Biography,Followers,CreationDate")] Profile profile)
        {
            if (id != profile.Id)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfileExists(profile.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profile
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profile == null)
            {
                return NotFound();
            }
            return View(profile);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var profile = await _context.Profile.FindAsync(id);
            var likes = _context.LikeList.Where(m => m.ProfileId == id);
            var followers = _context.FollowerList.Where(m => m.FollowerId == id);
            var stories = _context.Story.Where(m => m.ProfileId == id);

            foreach (var story in stories)
            {
                var likes2 = _context.LikeList.Where(m => m.StoryId == story.Id);

                foreach (var like in likes2)
                {
                    _context.LikeList.Remove(like);
                }
            }
            await _context.SaveChangesAsync();

            foreach (var like in likes) {
                if (like.ProfileId == id)
                {
                    var story = await _context.Story.FindAsync(like.StoryId);
                    story.Likes--;
                    _context.LikeList.Remove(like);
                }
            }
            await _context.SaveChangesAsync();

            foreach (var follower in followers)
            {
                if (follower.FollowerId == id)
                {
                    var followed = await _context.Profile.FindAsync(follower.ProfileId);
                    followed.Followers--;
                    _context.FollowerList.Remove(follower);
                }
            }
            await _context.SaveChangesAsync();

            _context.Profile.Remove(profile);
            await _context.SaveChangesAsync();
            user.SetProfileId(0);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfileExists(int id)
        {
            return _context.Profile.Any(e => e.Id == id);
        }
    }
}
