using interval_recall.Models.DTOs;

namespace IntervalRecall.UI.Services.Contracts
{
    public interface IQuestionService
    {
        Task<List<OutRecallQuestionGroupDTO>> GetRecallQuestions(Guid? questionGroupId);
        Task<HttpResponseMessage> GetAnswersAsync(List<InUserResponceDTO> userResponces);

    }
}
