using Microsoft.EntityFrameworkCore;
using SaleSpy.Core.Models;
using SaleSpy.Core.Resources.Response;
using SaleSpy.Core.Services;
using SaleSpy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleSpy.Services.Services
{
    public class ArticleSaleService : IArticleSaleService
    {
        private readonly SaleSpyDbContext _saleSpyDbContext;

        public ArticleSaleService(SaleSpyDbContext saleSpyDbContext)
        {
            _saleSpyDbContext = saleSpyDbContext;
        }

        public async Task<List<ArticleSale>> GetAll()
        {
            return await _saleSpyDbContext.ArticleSales.ToListAsync();
        }

        public async Task<ArticleSale> Create(ArticleSale newArticleSale)
        {
            await _saleSpyDbContext.AddAsync(newArticleSale);
            await _saleSpyDbContext.SaveChangesAsync();

            return newArticleSale;
        }

        public async Task<TimesSoldByDateResource> NumberOfArticleSalesByDate(DateTime date)
        {
            return new TimesSoldByDateResource
            {
                SoldOn = date,
                TimesSold = await _saleSpyDbContext.ArticleSales.Where(x => x.SoldOn.Date.Equals(date.Date)).CountAsync()
            };
        }

        public async Task<List<TimesSoldByDateResource>> NumberOfArticleSalesPerDay()
        {
            return await _saleSpyDbContext.ArticleSales.GroupBy(x => x.SoldOn.Date).Select(x => new TimesSoldByDateResource
            {
                SoldOn = x.Key,
                TimesSold = x.Count()
            }).ToListAsync();
        }

        public async Task<RevenueByDateResource> RevenueByDate(DateTime date)
        {
            return new RevenueByDateResource
            {
                SoldOn = date,
                Revenue = await _saleSpyDbContext.ArticleSales.Where(x => x.SoldOn.Date.Equals(date.Date)).SumAsync(x => x.SalesPrice)
            };
        }

        public async Task<List<RevenueByDateResource>> RevenuePerDay()
        {
            return await _saleSpyDbContext.ArticleSales.GroupBy(x => x.SoldOn.Date).Select(x => new RevenueByDateResource
            {
                SoldOn = x.Key,
                Revenue = x.Sum(c => c.SalesPrice)
            }).ToListAsync();
        }

        public async Task<List<RevenueByArticleResource>> RevenueGroupedByArticles()
        {
            return await _saleSpyDbContext.ArticleSales.GroupBy(x => x.ArticleNumber).Select(cl => new RevenueByArticleResource
            {
                ArticleNumber = cl.Key,
                Revenue = cl.Sum(c => c.SalesPrice)
            }).ToListAsync();
        }
    }
}
