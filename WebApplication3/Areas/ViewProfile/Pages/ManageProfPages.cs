using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication3.Areas.ViewProfile.Pages
{
    public static class ManageProfPages
    {
        public static string Index => "Index";

        public static string Biography => "Biography";

        public static string Followers => "Followers";

        public static string Likes => "Likes";

        public static string PicturesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        public static string BiographyNavClass(ViewContext viewContext) => PageNavClass(viewContext, Biography);

        public static string FollowersNavClass(ViewContext viewContext) => PageNavClass(viewContext, Followers);

        public static string LikesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Likes);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
