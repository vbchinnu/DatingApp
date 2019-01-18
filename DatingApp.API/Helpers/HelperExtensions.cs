using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class HelperExtensions
    {
        public static void AddApplicationError(this HttpResponse response, string errormessage)
        {
            response.Headers.Add("Application-Error", errormessage);
            response.Headers.Add("Acccess-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Acccess-Control-Allow-Orgin", "*");
        }
    }
}