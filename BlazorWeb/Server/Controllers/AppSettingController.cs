using Application.Master;
using Application.Master.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppSettingController : ControllerBase
    {
        private readonly ILogger<AppSettingController> _logger;
        private readonly IAppSettingService appSettingService;
        public AppSettingController(ILogger<AppSettingController> logger, IAppSettingService appSettingService)
        {
            _logger = logger;
            this.appSettingService = appSettingService;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        { 
            return Ok( await appSettingService.GetAppSettingsAsync() );
        }
        [HttpPost("Upsert")]
        public async Task<IActionResult> Upsert(AppSettingVm appSettingVm)
        {
            return Ok(await appSettingService.UpsertAsync( appSettingVm));
        }
    }
}
