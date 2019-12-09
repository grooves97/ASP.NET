using CookieAuthLesson.DataAccess;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookieAuthLesson.Services
{
    public class AuthService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly AuthContext context;

        public AuthService(IHttpContextAccessor httpContextAccessor,AuthContext context)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.context = context;
        }

        public async Task<bool> AuthenticateUser(string email, string password)
        {
            var user = await context.Users.SingleOrDefaultAsync(u => u.Email==email 
            && u.Password==password);

            if (user == null) 
                return false;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = false,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                RedirectUri = "Home/Index"
            };

            await httpContextAccessor.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return true;
        }
    }
}
