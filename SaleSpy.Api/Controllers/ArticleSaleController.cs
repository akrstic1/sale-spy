using Microsoft.AspNetCore.Mvc;
using SaleSpy.Core.Resources.Request;
using SaleSpy.Core.Services;
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

        /// <summary>
        /// Gets all sale records
        /// </summary>
        /// <returns>All sale records</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _articleSaleService.GetAll();

            return Ok(result);
        }

        /// <summary>
        /// Creates a new sale record.
        /// </summary>
        /// <returns>A newly created sale record.</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     {
        ///        "articleNumber": qwertz12345,
        ///        "salesPrice": 32.53,
        ///     }
        ///
        /// </remarks>
        /// <returns>Newly created sale record</returns>
        /// <response code="200">Returns the newly created sale record</response>
        [HttpPost]
        public async Task<IActionResult> Create(CreateArticleSaleResource createArticleSaleResource)
        {
            var result = await _articleSaleService.Create(CreateArticleSaleResource.ToArticleSale(createArticleSaleResource));

            return Ok(result);
        }

        /// <summary>
        /// Gets all recorded sales on the defined date
        /// </summary>
        /// <param name="date">Date to show records on</param>
        /// <returns>List of sales numbers on the defined date</returns>
        /// <response code="200">Returns a list of sales numbers on the defined date</response>
        [HttpGet("{date}")]
        public async Task<IActionResult> NumberOfSoldArticlesByDate(DateTime date)
        {
            var result = await _articleSaleService.NumberOfArticleSalesByDate(date);

            return Ok(result);
        }

        /// <summary>
        /// Gets a list of quanitity of sale records by each day
        /// </summary>
        /// <returns>List of sales numbers by each day</returns>
        /// <response code="200">Returns a list of sales numbers by each day</response>
        [HttpGet]
        public async Task<IActionResult> NumberOfSoldArticlesPerDay()
        {
            var result = await _articleSaleService.NumberOfArticleSalesPerDay();

            return Ok(result);
        }


        /// <summary>
        /// Gets revenue on the defined date
        /// </summary>
        /// <param name="date">Revenue on date</param>
        /// <returns>Revenue on defined date</returns>
        /// <response code="200">Returns revenue on the defined date</response>
        [HttpGet("{date}")]
        public async Task<IActionResult> RevenueByDate(DateTime date)
        {
            var result = await _articleSaleService.RevenueByDate(date);

            return Ok(result);
        }

        /// <summary>
        /// Gets a list of total revenue by each day
        /// </summary>
        /// <returns>List of total revenue by each day</returns>
        /// <response code="200">Returns a list of total revenue by each day</response>
        [HttpGet]
        public async Task<IActionResult> RevenuePerDay()
        {
            var result = await _articleSaleService.RevenuePerDay();

            return Ok(result);
        }

        /// <summary>
        /// Gets a list of total revenue by article
        /// </summary>
        /// <returns>List of total revenue by article</returns>
        /// <response code="200">Returns a list of total revenue by article</response>
        [HttpGet]
        public async Task<IActionResult> RevenueGroupedByArticles()
        {
            var result = await _articleSaleService.RevenueGroupedByArticles();

            return Ok(result);
        }
    }
}
