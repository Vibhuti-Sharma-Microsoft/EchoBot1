using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EchoBot1.Middlewares
{
    /*
     * Step 4: Filter the search results to show only results user has access to.
     * Make Http call to Graph API to get user's access rights
     */
    public class FilterResults : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
