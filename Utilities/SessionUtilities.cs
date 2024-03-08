using FribergRentals.Components.Pages.UserPages;
using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;
using FribergRentals.Data.Repositories;

namespace FribergRentals.Utilities
{
    public class SessionUtilities
    {
        private readonly IUser<User> userRepo;

        public SessionUtilities(IUser<User> userRepo)
        {
            this.userRepo = userRepo;
        }
        public string ExtractSessionToken(HttpContext httpContext)
        {
            if (httpContext != null)
            {
                var sessionToken = httpContext.Request.Cookies["SessionToken"];
                if (sessionToken != null)
                {
                    return sessionToken;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public async Task ClearSession(HttpContext httpContext)
        {
            var sessionToken = httpContext.Request.Cookies["SessionToken"].ToString();
            if (!string.IsNullOrEmpty(sessionToken))
            {
                httpContext.Response.OnStarting(async () =>
                {
                    httpContext.Response.Cookies.Delete("SessionToken");
                    await Task.CompletedTask;
                });
            }
        }

        public async Task<string> CheckUser(string sessionToken)
        {
            if (string.IsNullOrEmpty(sessionToken))
            {
                return "Not logged in";
            }

            if (!string.IsNullOrEmpty(sessionToken))
            {
                User user = await userRepo.ValidateSessionToken(sessionToken);
                if (user is Customer)
                {
                    return "user";
                }
                else if (user is Admin)
                {
                    return "admin";
                }

            }
            return "Not logged in";
        }
    }
}
