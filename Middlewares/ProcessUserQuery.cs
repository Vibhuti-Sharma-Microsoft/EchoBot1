using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EchoBot1.Middlewares
{
    public class ProcessUserQuery : IMiddleware
    {
        /*
        * Step 1: Perform any actions to enhance/clean up the user query using AI 
        */
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
