using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Taxually_Linux_Function_Test_App.Functions.Home;

public class HomeFunction
{
    [Function("HttpFunction")]
    public static HttpResponseData Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "index")] HttpRequestData req,
        FunctionContext executionContext)
    {
        var logger = executionContext.GetLogger("HttpFunction");
        logger.LogInformation("Request handling started");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
        response.WriteString("Function is working!");
        
        logger.LogInformation("Request handling finished");
        
        return response;
    }
}
