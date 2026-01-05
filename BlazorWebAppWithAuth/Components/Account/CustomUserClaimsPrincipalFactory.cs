using System.Security.Claims;
using BlazorWebAppWithAuth.Data;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity;

namespace BlazorWebAppWithAuth.Components.Account
{
    public class CustomUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager, IOptions<IdentityOptions> options)
        : UserClaimsPrincipalFactory<ApplicationUser>(userManager, options)
    {

    }
}