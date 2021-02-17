using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipaleExtensions
    {
        public static string Getusername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }
        public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}