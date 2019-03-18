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
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Areas.ViewProfile.Pages
{
    public class FollowersModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        int userProfileId;

        public FollowersModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

        public async void setUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            userProfileId = user.GetProfileId();
        }

        public int IsFollowedByUser(string id)
        {
            var followedByUserList = _context.FollowerList.Where(m => m.FollowerId.ToString() == userProfileId.ToString());
            int isFollowed = 0;

            foreach (var followed in followedByUserList)
            {
                if (followed.ProfileId.ToString() == id)
                    isFollowed = 1;
                else
                    isFollowed = 2;

                if (isFollowed == 1)
                    return isFollowed;
            }
            return isFollowed;
        }

        public int GetFollowers(string id)
        {
            var listOfFollowers = _context.FollowerList.Where(m => m.ProfileId.ToString() == id);
            int i = 0;

            foreach (var follower in listOfFollowers)
            {
                var followingProfile = _context.Profile.FirstOrDefault(m => m.Id == follower.FollowerId);
                ViewData["name" + i.ToString()] = followingProfile.UserName;
                ViewData["id" + i.ToString()] = followingProfile.Id;
                ViewData["numFollowers" + i.ToString()] = followingProfile.Followers;
                ViewData["date" + i.ToString()] = followingProfile.CreationDate.ToString("MM/dd/yyyy");
                i++;
            }
            return i;
        }

        public void OnGet()
        {

        }
    }
}