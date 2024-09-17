using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EchoBot1.Middlewares
{
    /*
     * Step 5: Construct the response to be sent back to the user. Enhance using AI as needed.
     */
    public class ConstructResponse : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
