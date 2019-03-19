using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;

namespace WebApplication3.Areas.Identity.Pages.Account.Manage
{
    public class DeletePersonalDataModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<DeletePersonalDataModel> _logger;
        private readonly ApplicationDbContext _context;

        public DeletePersonalDataModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<DeletePersonalDataModel> logger,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public bool RequirePassword { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            RequirePassword = await _userManager.HasPasswordAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            RequirePassword = await _userManager.HasPasswordAsync(user);
            if (RequirePassword)
            {
                if (!await _userManager.CheckPasswordAsync(user, Input.Password))
                {
                    ModelState.AddModelError(string.Empty, "Password not correct.");
                    return Page();
                }
            }
            var likes = _context.LikeList.Where(m => m.ProfileId == user.ProfileId);
            var followers = _context.FollowerList.Where(m => m.FollowerId == user.ProfileId);
            var stories = _context.Story.Where(m => m.ProfileId == user.ProfileId);

            foreach (var story in stories)
            {
                var likes2 = _context.LikeList.Where(m => m.StoryId == story.Id);

                foreach (var like in likes2)
                {
                    _context.LikeList.Remove(like);
                }
            }
            await _context.SaveChangesAsync();

            foreach (var like in likes)
            {
                if (like.ProfileId == user.ProfileId)
                {
                    var story = await _context.Story.FindAsync(like.StoryId);
                    story.Likes--;
                    _context.LikeList.Remove(like);
                }
            }
            await _context.SaveChangesAsync();

            foreach (var follower in followers)
            {
                if (follower.FollowerId == user.ProfileId)
                {
                    var followed = await _context.Profile.FindAsync(follower.ProfileId);
                    followed.Followers--;
                    _context.FollowerList.Remove(follower);
                }
            }
            await _context.SaveChangesAsync();

            var result = await _userManager.DeleteAsync(user);
            var userId = await _userManager.GetUserIdAsync(user);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Unexpected error occurred deleteing user with ID '{userId}'.");
            }

            await _signInManager.SignOutAsync();

            _logger.LogInformation("User with ID '{UserId}' deleted themselves.", userId);

            return Redirect("~/");
        }
    }
}