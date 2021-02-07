using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipaleExtensions
    {
        public static string Getusername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}