using interval_recall.Models.DTOs;

namespace IntervalRecall.UI.Services.Contracts
{
    public interface IStatisticService
    {
        Task<List<QuestionGroupStatistic>> GetStatisticAsync(Guid? questionGroupId);
        Task RemoveStatisticAsync(Guid questionGroupId);
    }
}
