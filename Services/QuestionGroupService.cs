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

        public async Task<List<OutQuestionGroupDTO>> GetAllGroupsAsync()
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

        public async Task<OutQuestionGroupDTO> GetGroupByIdAsync(Guid questionGroupId)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<OutQuestionGroupDTO>($"api/v1/question-groups/{questionGroupId}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<HttpResponseMessage> UpdateQuestionGroup(OutQuestionGroupDTO updateQuestionGroupDTO) 
        {
            try
            {
                return await httpClient.PatchAsJsonAsync($"api/v1/question-groups", updateQuestionGroupDTO);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
