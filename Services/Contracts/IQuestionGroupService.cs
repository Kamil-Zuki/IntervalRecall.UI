using interval_recall.Models.DTOs;

namespace IntervalRecall.UI.Services.Contracts
{
    public interface IQuestionGroupService
    {
        Task<List<OutQuestionGroupDTO>> GetGroups();
    }
}
