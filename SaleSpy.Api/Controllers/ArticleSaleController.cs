using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleSpy.Core.Models;
using SaleSpy.Core.Resources;
using SaleSpy.Core.Services;
using SaleSpy.Services.Services;
using System;
using System.Threading.Tasks;

namespace SaleSpy.Api.Controllers
{
    [Route("api/[controller]/[action]")]
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
            var result = await _articleSaleService.GetAll();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateArticleSaleResource createArticleSaleResource)
        {
            var result = await _articleSaleService.Create(CreateArticleSaleResource.ToArticleSale(createArticleSaleResource));

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> NumberOfSoldArticlesByDate(DateTime date)
        {
            var result = await _articleSaleService.NumberOfArticleSalesByDate(date);

            return Ok(new { NumberOfSoldArticles = result });
        }

        [HttpGet]
        public async Task<IActionResult> NumberOfSoldArticlesPerDay()
        {
            var result = await _articleSaleService.NumberOfArticleSalesPerDay();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> RevenueByDate(DateTime date)
        {
            var result = await _articleSaleService.RevenueByDate(date);

            return Ok(new { Revenue = result });
        }

        [HttpGet]
        public async Task<IActionResult> RevenuePerDay()
        {
            var result = await _articleSaleService.RevenuePerDay();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> RevenueGroupedByArticles()
        {
            var result = await _articleSaleService.RevenueGroupedByArticles();

            return Ok(result);
        }
    }
}
