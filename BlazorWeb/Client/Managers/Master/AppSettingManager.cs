using BlazorWeb.Shared.Commom;
using BlazorWeb.Shared.Master;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace BlazorWeb.Client.Managers.Master
{
    public class AppSettingManager : IAppSettingManager
    {
        private readonly HttpClient _httpClient;
        #region EndPoints
        private string GetAll = "api/AppSetting/getAll";
        private string Upsert = "api/AppSetting/Upsert";
        #endregion
        public AppSettingManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ResponseModel<List<AppSettingVm>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(GetAll);
            if (response.IsSuccessStatusCode)
            {
                var responseAsString = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<ResponseModel<List<AppSettingVm>>>(responseAsString);
                return responseModel;
            }
            else
                return new ResponseModel<List<AppSettingVm>>()
                {
                    Success = false,
                    Message = "API Response Error",
                    Output = null
                };

        }

        public async Task<ResponseModel<AppSettingVm>> SaveUpdateAsync(AppSettingVm appSettingVm)
        {
            var response = await _httpClient.PostAsJsonAsync(Upsert, appSettingVm);
            if (response.IsSuccessStatusCode)
            {
                var responseAsString = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<ResponseModel<AppSettingVm>>(responseAsString);
                return responseModel;
            }
            else
                return new ResponseModel<AppSettingVm>()
                {
                    Success = false,
                    Message = "API Response Error",
                    Output = null
                };
        }
    }
}
