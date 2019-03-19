using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;
using PagedList;

namespace WebApplication3.Controllers
{
    public class StoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public StoriesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Like(int storyId, string returnUrl)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var profileId = user.GetProfileId();
            var isLiked = await _context.LikeList.FindAsync(profileId, storyId);
            LikeList newLike = new LikeList();
            var story = await _context.Story.FindAsync(storyId);

            if (ModelState.IsValid)
            {
                if (isLiked == null)
                {
                    story.Likes++;
                    newLike.ProfileId = profileId;
                    newLike.StoryId = storyId;
                    _context.Add(newLike);
                    await _context.SaveChangesAsync();
                }
            }
            return Redirect(returnUrl);
        }

        public async Task<IActionResult> UnLike(int storyId, string returnUrl)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var profileId = user.GetProfileId();
            var tuple = await _context.LikeList.FindAsync(profileId, storyId);
            var story = await _context.Story.FindAsync(storyId);

            if (ModelState.IsValid)
            {
                if (tuple != null)
                {
                    story.Likes--;
                    _context.LikeList.Remove(tuple);
                    await _context.SaveChangesAsync();
                }
            }
            return Redirect(returnUrl);
        }

        // Get, filter and sort stories
        public async Task<IActionResult> Index(string order, string title, string author, string genre, string length, bool useless)
        {
            var stories = from m in _context.Story select m;

            if (!string.IsNullOrEmpty(title))
            {
                stories = stories.Where(s => s.Title.Contains(title));
            }

            if (!string.IsNullOrEmpty(author))
            {
                stories = stories.Where(s => s.Author.Contains(author));
            }

            if (!string.IsNullOrEmpty(genre))
            {
                stories = stories.Where(s => s.Genre == genre);
            }

            if (!string.IsNullOrEmpty(length))
            {
                if (length == "Very short")
                    stories = stories.Where(s => s.EstimatedLength < 5);
                else if (length == "Short")
                    stories = stories.Where(s => s.EstimatedLength < 10 && s.EstimatedLength >= 5);
                else if (length == "Medium")
                    stories = stories.Where(s => s.EstimatedLength < 20 && s.EstimatedLength >= 10);
                else if (length == "Long")
                    stories = stories.Where(s => s.EstimatedLength < 30 && s.EstimatedLength >= 20);
                else if (length == "Very long")
                    stories = stories.Where(s => s.EstimatedLength > 30);
            }

            if (!string.IsNullOrEmpty(order))
            {
                if (order == "New")
                    stories = stories.OrderByDescending(s => s.CreationDate);
                else if (order == "Old")
                    stories = stories.OrderBy(s => s.CreationDate);
                else if (order == "Most")
                    stories = stories.OrderByDescending(s => s.Likes);
                else if (order == "Least")
                    stories = stories.OrderBy(s => s.Likes);
            }
            else
            {
                stories = stories.OrderByDescending(s => s.CreationDate);
            }
            return View(await stories.ToListAsync());
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story
                .FirstOrDefaultAsync(m => m.Id == id);
            if (story == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                var userProfileId = user.GetProfileId();
                var check = await _context.LikeList.FindAsync(userProfileId, story.Id);
                ViewData["isLiked"] = LikedByUser(check, userProfileId);
            }
            return View(story);
        }

        public string LikedByUser(LikeList check, int userProfileId)
        {
            string isLiked = "no";

            if (check == null)
                isLiked = "no";
            else if (check.ProfileId == userProfileId)
                isLiked = "yes";

            return isLiked;
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProfileId,Title,Genre,Content")] Story story, string Content)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var userProfileId = user.GetProfileId();
            var profile = await _context.Profile.FindAsync(userProfileId);
            double length = Content.Length;
            double minutes = Convert.ToInt32(Math.Floor(length / 900));
            double seconds = Math.Ceiling(Math.Round(((length / 900) - Math.Truncate(length / 900)) * 60) / 10) * 10;

            if (ModelState.IsValid)
            {
                story.CreationDate = DateTime.Now;
                story.ProfileId = userProfileId;
                story.Author = profile.UserName;
                story.EstimatedLength = (int)minutes;
                story.EstimatedLengthSeconds = (int)seconds;
                _context.Add(story);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(story);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story.FindAsync(id);
            if (story == null)
            {
                return NotFound();
            }
            return View(story);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfileId,Likes,Title,Content,Author,IsEdited,EstimatedLength,CreationDate,Genre,EstimatedLengthSeconds,EditDate")] Story story)
        {
            double length = story.Content.Length;
            double minutes = Convert.ToInt32(Math.Floor(length / 900));
            double seconds = Math.Ceiling(Math.Round(((length / 900) - Math.Truncate(length / 900)) * 60) / 10) * 10;

            if (id != story.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    story.EstimatedLength = (int)minutes;
                    story.EstimatedLengthSeconds = (int)seconds;
                    story.IsEdited = true;
                    story.EditDate = DateTime.Now;
                    _context.Update(story);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoryExists(story.Id))
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
            return View(story);
        }
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var story = await _context.Story
                .FirstOrDefaultAsync(m => m.Id == id);
            if (story == null)
            {
                return NotFound();
            }

            return View(story);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var story = await _context.Story.FindAsync(id);
            var likes = _context.LikeList.Where(m => m.StoryId == id);

            foreach (var like in likes)
            {
                _context.LikeList.Remove(like);
            }
            await _context.SaveChangesAsync();

            _context.Story.Remove(story);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoryExists(int id)
        {
            return _context.Story.Any(e => e.Id == id);
        }
    }
}
