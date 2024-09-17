using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EchoBot1.Middlewares
{
    /*
     * Step 3: Execute the search query by making http call to Azure Cognitive Search
     */
    public class ExecuteSearchQuery : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
