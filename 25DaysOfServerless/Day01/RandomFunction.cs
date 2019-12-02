using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Day01.Services;
using System;

namespace Day01
{
    public class RandomFunction
    {
        private readonly IRandomService _randomService;

        public RandomFunction(IRandomService randomService)
        {
            _randomService = randomService;
        }

        [FunctionName("RandomFunction")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "day01")] HttpRequest req)
        {
            try
            {
                var randomElement = _randomService.GetRandom();
                return new OkObjectResult(randomElement);
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(ex);
            }
        }
    }
}
