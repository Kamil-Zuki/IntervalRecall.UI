using interval_recall.Models.DTOs;
using IntervalRecall.UI.Services.Contracts;
using System.Net.Http.Json;

namespace IntervalRecall.UI.Services
{
    public class QuestionGroupService : IQuestionGroupService
    {
        private readonly HttpClient httpClient;

        public QuestionGroupService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<OutQuestionGroupDTO>> GetGroups()
        {
            try
            {
                var questionGroups = await httpClient.GetFromJsonAsync<List<OutQuestionGroupDTO>>("api/v1/question-groups");
                return questionGroups;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
