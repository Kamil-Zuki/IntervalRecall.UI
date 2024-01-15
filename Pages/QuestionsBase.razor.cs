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
        public List<QuestionsAmountInfoWithGroupId> QuestionsAmountInfo { get; set; }
        protected override async Task OnInitializedAsync()
        {
            QuestionGroups = await QuestionService.GetRecallQuestions(QuestionGroupId);
            QuestionsAmountInfo = new();
            foreach (var group in QuestionGroups)
            {
                var questionAmountInfo = await QuestionService.GetQuestionsAmountAsync(group.Id);
                QuestionsAmountInfo.Add(new QuestionsAmountInfoWithGroupId()
                {
                    GroupId = group.Id,
                    NewQuestions = questionAmountInfo.NewQuestions,
                    LearnAndGraduatedQuestions = questionAmountInfo.LearnAndGraduatedQuestions
                });
            }
        }
    }
}
