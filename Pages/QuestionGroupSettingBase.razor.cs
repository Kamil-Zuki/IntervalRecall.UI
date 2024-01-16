using interval_recall.Models.DTOs;
using IntervalRecall.UI.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace IntervalRecall.UI.Pages
{
    public class QuestionGroupSettingBase : ComponentBase
    {
        [Inject]
        public IQuestionGroupService QuestionGroupService { get; set; }

        public OutQuestionGroupDTO QuestionGroup { get; set; }
        [Parameter]
        public Guid QuestionGroupId { get; set; }
        protected override async Task OnInitializedAsync()
        {
            QuestionGroup = await QuestionGroupService.GetGroupByIdAsync(QuestionGroupId);
        }
    }
}
