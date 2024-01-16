using interval_recall.Models.DTOs;

namespace IntervalRecall.UI.Services.Contracts
{
    public interface IQuestionGroupService
    {
        Task<List<OutQuestionGroupDTO>> GetAllGroupsAsync();
        Task<OutQuestionGroupDTO> GetGroupByIdAsync(Guid id);
        Task<HttpResponseMessage> UpdateQuestionGroup(OutQuestionGroupDTO updateQuestionGroupDTO);
    }
}
