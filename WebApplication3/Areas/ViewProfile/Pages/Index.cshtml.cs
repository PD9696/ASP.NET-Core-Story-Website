using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Areas.ViewProfile.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public void SetProfile(string id)
        {
            var profile = _context.Profile
                .FirstOrDefault(m => m.Id.ToString() == id);

            ViewData["name"] = profile.UserName;
            ViewData["profileId"] = profile.Id;
            ViewData["description"] = profile.QuickDescription;
            ViewData["numFollowers"] = profile.Followers;
            ViewData["date"] = profile.CreationDate.ToString("MM/dd/yyyy");
        }

        public void isFollowing(string id, int userProfileId)
        {
            var profile = _context.Profile
                .FirstOrDefault(m => m.Id.ToString() == id);
            ViewData["following"] = 0;

                if (userProfileId > 0)
                {
                    var isFollowed = _context.FollowerList.Find(profile.Id, userProfileId);

                    if (isFollowed == null)
                    {
                        ViewData["following"] = 2;
                    }
                    else if (isFollowed.FollowerId == userProfileId)
                    {
                        ViewData["following"] = 1;
                    }
                }
        }

        public int GetStories(string id)
        {
            var listOfStories = _context.Story.Where(m => m.ProfileId.ToString() == id);
            int i = 0;

            foreach (var story in listOfStories)
            {
                ViewData["title" + i.ToString()] = story.Title;
                ViewData["id" + i.ToString()] = story.Id;
                ViewData["id" + i.ToString()] = story.Id;
                ViewData["genre" + i.ToString()] = story.Genre;
                ViewData["minutes" + i.ToString()] = story.EstimatedLength;
                ViewData["seconds" + i.ToString()] = story.EstimatedLengthSeconds;
                ViewData["date" + i.ToString()] = story.CreationDate;
                ViewData["likes" + i.ToString()] = story.Likes;
                i++;
            }
            return i;
        }

        public void OnGet()
        {

        }
    }
}