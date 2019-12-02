using Day01;
using Day01.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Day01
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton(typeof(IRandomService), CreateRandomService());
        }

        private IRandomService CreateRandomService()
        {
            return new RandomService(new[] { "נ", "ג", "ה", "ש" });
        }
    }
}
