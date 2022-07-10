using SaleSpy.Core.Models;
using SaleSpy.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleSpy.Core.Services
{
    public interface IArticleSaleService
    {
        Task<ArticleSale> Create(ArticleSale newArticleSale);
        Task<List<ArticleSale>> GetAll();
        Task<int> NumberOfArticleSalesByDate(DateTime date);
        Task<List<TimesSoldByDate>> NumberOfArticleSalesPerDay();
        Task<decimal> RevenueByDate(DateTime date);
        Task<List<RevenueByArticle>> RevenueGroupedByArticles();
        Task<List<RevenueByDate>> RevenuePerDay();
    }
}
