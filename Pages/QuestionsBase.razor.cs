using interval_recall.Models.DTOs;
using IntervalRecall.UI.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace IntervalRecall.UI.Pages
{
    public class QuestionsBase : ComponentBase
    {
        [Inject]
        public IQuestionService QuestionService { get; set; }

        [Inject]
        public IStatisticService StatisticService { get; set; }

        [Parameter]
        public Guid? QuestionGroupId { get; set; }  // Add a parameter to receive the questionGroupId

        public List<OutRecallQuestionGroupDTO> QuestionGroups { get; set; }

        protected override async Task OnInitializedAsync()
        {
            QuestionGroups = await QuestionService.GetRecallQuestions(QuestionGroupId);
        }
    }   
}
