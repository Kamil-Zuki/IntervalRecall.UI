using interval_recall.Models.DTOs;
using IntervalRecall.UI.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace IntervalRecall.UI.Pages
{
    public class QuestionGroupsBase : ComponentBase
    {
        [Inject]
        public IQuestionGroupService QuestionGroupService { get; set; }

        
        public List<OutQuestionGroupDTO> QuestionGroups { get; set; }
        //public List<OutRecallQuestionGroupDTO> RecallQuestions { get; set; }

        protected override async Task OnInitializedAsync()
        {
            QuestionGroups = await QuestionGroupService.GetGroups();
            //RecallQuestions = await QuestionService.GetRecallQuestions();
        }
    }
}
