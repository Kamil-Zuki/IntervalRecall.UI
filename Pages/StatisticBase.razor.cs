using interval_recall.Models.DTOs;
using IntervalRecall.UI.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace IntervalRecall.UI.Pages
{
    public class StatisticBase : ComponentBase
    {
        [Inject]
        public IStatisticService StatisticService { get; set; }
        public List<QuestionGroupStatistic> QuestionGroupStatistics { get; set; }

        [Parameter]
        public Guid? QuestionGroupId { get; set; }
        protected override async Task OnInitializedAsync()
        {
            QuestionGroupStatistics = await StatisticService.GetStatisticAsync(QuestionGroupId);
        }

    }
}
