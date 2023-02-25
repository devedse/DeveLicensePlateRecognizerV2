using DLPR.LicensePlateData.Application.Interfaces;
using DLPR.LicensePlateData.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DLPR.LicensePlateData.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LicensePlateController : ControllerBase
    {
        private readonly ILicensePlateService _licensePlateService;

        public LicensePlateController(ILicensePlateService licensePlateService)
        {
            _licensePlateService = licensePlateService;
        }

        [HttpGet]
        public async Task<ActionResult<LicensePlate?>> GetLicensePlateByKey(string licensePlateText)
        {
            var result = await _licensePlateService.GetLicensePlateByKey(licensePlateText);
            return Ok(result);
        }
    }
}
