using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleSpy.Core.Services;
using SaleSpy.Services.Services;
using System.Threading.Tasks;

namespace SaleSpy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleSaleController : ControllerBase
    {
        private readonly IArticleSaleService _articleSaleService;

        public ArticleSaleController(IArticleSaleService articleSaleService)
        {
            _articleSaleService = articleSaleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _articleSaleService.GetAllArticleSales();

            return Ok(result);
        }
    }
}
