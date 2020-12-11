using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Library.Models;

namespace Library.Functions
{
    public static class ListBooks
    {
        [FunctionName("list")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "list")] 
            HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Listing all books");

            var list = new List<Book>();

            // TODO Get list of books

            return new OkObjectResult(list.ToArray());
        }
    }
}
