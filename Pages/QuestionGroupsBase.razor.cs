using interval_recall.Models.DTOs;
using IntervalRecall.UI.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace IntervalRecall.UI.Pages
{
    public class QuestionGroupsBase : ComponentBase
    {
        [Inject]
        public IQuestionGroupService QuestionGroupService { get; set; }

        [Inject]
        public IQuestionService QuestionService { get; set; }

        public List<OutQuestionGroupDTO> QuestionGroups { get; set; }

        
        protected override async Task OnInitializedAsync()
        {
            QuestionGroups = await QuestionGroupService.GetGroups();

            foreach(var group in QuestionGroups)
            {
                var questionAmountInfo = await QuestionService.GetQuestionsAmountAsync(group.Id);
                
            }
            
        }
    }
}
