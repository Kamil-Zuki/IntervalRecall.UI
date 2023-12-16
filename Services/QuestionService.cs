using interval_recall.Models.DTOs;
using IntervalRecall.UI.Services.Contracts;
using System.Net.Http.Json;

namespace IntervalRecall.UI.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly HttpClient httpClient;

        public QuestionService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<OutRecallQuestionGroupDTO>> GetRecallQuestions(Guid? questionGroupId)
        {
            try
            {
                if(questionGroupId != null)
                    return await httpClient.GetFromJsonAsync<List<OutRecallQuestionGroupDTO>>($"api/v1/questions?questionGroupId={questionGroupId}");
                else
                    return await httpClient.GetFromJsonAsync<List<OutRecallQuestionGroupDTO>>($"api/v1/questions");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<HttpResponseMessage> GetAnswersAsync(List<InUserResponceDTO> userResponces)
        {
            return await httpClient.PostAsJsonAsync($"api/v1/questions/answers", userResponces);
        }

    }
}
