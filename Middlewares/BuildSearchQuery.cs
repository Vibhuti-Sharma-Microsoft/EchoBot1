using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EchoBot1.Middlewares
{
    /*
     * Step 2: Build a search query using the cleaned up user query
     */
    public class BuildSearchQuery : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
