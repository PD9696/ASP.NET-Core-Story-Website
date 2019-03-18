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

namespace WebApplication3.Controllers
{
    public class FollowerListsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FollowerListsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //Return to list of profiles
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Follow(int idBeingFollowed, [Bind("Id,ProfileId,FollowerId")] FollowerList follower)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var profileBeingFollowed = await _context.Profile.FindAsync(idBeingFollowed);

            if (ModelState.IsValid)
            {
                profileBeingFollowed.Followers++;
                follower.ProfileId = idBeingFollowed;
                follower.FollowerId = user.GetProfileId();
                _context.Add(follower);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Profiles");
        }

        //Return to custom URL
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Follow1(int idBeingFollowed, [Bind("Id,ProfileId,FollowerId")] FollowerList follower, string returnUrl)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var profileBeingFollowed = await _context.Profile.FindAsync(idBeingFollowed);

            if (ModelState.IsValid)
            {
                profileBeingFollowed.Followers++;
                follower.ProfileId = idBeingFollowed;
                follower.FollowerId = user.GetProfileId();
                _context.Add(follower);
                await _context.SaveChangesAsync();
            }
            return Redirect(returnUrl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Unfollow(int idBeingFollowed)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var profileId = idBeingFollowed;
            var followerId = user.GetProfileId();
            var tuple = await _context.FollowerList.FindAsync(profileId, followerId);
            var profileBeingFollowed = await _context.Profile.FindAsync(idBeingFollowed);

            profileBeingFollowed.Followers--;
            _context.FollowerList.Remove(tuple);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Profiles");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Unfollow1(int idBeingFollowed, string returnUrl)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var profileId = idBeingFollowed;
            var followerId = user.GetProfileId();
            var tuple = await _context.FollowerList.FindAsync(profileId, followerId);
            var profileBeingFollowed = await _context.Profile.FindAsync(idBeingFollowed);

            profileBeingFollowed.Followers--;
            _context.FollowerList.Remove(tuple);
            await _context.SaveChangesAsync();
            return Redirect(returnUrl);
        }
    }
}