using IntervalRecall.UI.Services.Contracts;
using IntervalRecall.UI.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace IntervalRecall.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7061/") });
            builder.Services.AddScoped<IQuestionService, QuestionService>();
            builder.Services.AddScoped<IQuestionGroupService, QuestionGroupService>();
            builder.Services.AddScoped<IStatisticService, StatisticService>();
            builder.Services.AddSingleton<StateContainer>();

            await builder.Build().RunAsync();
        }
    }
}
