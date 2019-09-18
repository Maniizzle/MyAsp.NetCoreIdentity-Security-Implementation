using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MyAspIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspIdentity.CustomTagHelpers
{
    [HtmlTargetElement("td", Attributes ="identity-role")]
    public class RoleUsersTagHelper:TagHelper
    {
        private readonly UserManager<MideUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleUsersTagHelper(UserManager<MideUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HtmlAttributeName("identity-role")]
        public string Role { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {

            List<string> names = new List<string>();
            IdentityRole role = await roleManager.FindByIdAsync(Role);
            if (role != null)
            {
                foreach (var user in userManager.Users)
                {
                    if(user!=null && await userManager.IsInRoleAsync(user, role.Name))
                    {
                        names.Add(user.UserName);
                    }
                }
                
            }
            output.Content.SetContent(names.Count == 0 ? "No Users" : string.Join(",", names));
        }
    }
}
