using interval_recall.Models.DTOs;
using IntervalRecall.UI.Services.Contracts;
using System.Net.Http.Json;

namespace IntervalRecall.UI.Services
{
    public class StatisticService : IStatisticService
    {
        private readonly HttpClient httpClient;
        public StatisticService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<QuestionGroupStatistic>> GetStatisticAsync(Guid? questionGroupId)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<List<QuestionGroupStatistic>>($"api/v1/statistic?questionGroupId={questionGroupId}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task RemoveStatisticAsync(Guid questionGroupId)
        {
            try
            {
                await httpClient.DeleteAsync($"api/v1/statistic?questionGroupId={questionGroupId}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
