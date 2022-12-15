using BlazorWeb.Shared.Commom;
using BlazorWeb.Shared.Master;

namespace BlazorWeb.Client.Managers.Master
{
    public interface IAppSettingManager
    {
        Task<ResponseModel<List<AppSettingVm>>> GetAllAsync();
        Task<ResponseModel<AppSettingVm>> SaveUpdateAsync(AppSettingVm appSettingVm);
    }
}
