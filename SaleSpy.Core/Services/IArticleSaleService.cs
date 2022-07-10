using SaleSpy.Core.Models;
using SaleSpy.Core.Resources.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleSpy.Core.Services
{
    public interface IArticleSaleService
    {
        Task<ArticleSale> Create(ArticleSale newArticleSale);
        Task<List<ArticleSale>> GetAll();
        Task<TimesSoldByDateResource> NumberOfArticleSalesByDate(DateTime date);
        Task<List<TimesSoldByDateResource>> NumberOfArticleSalesPerDay();
        Task<RevenueByDateResource> RevenueByDate(DateTime date);
        Task<List<RevenueByArticleResource>> RevenueGroupedByArticles();
        Task<List<RevenueByDateResource>> RevenuePerDay();
    }
}
