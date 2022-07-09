using Microsoft.EntityFrameworkCore;
using SaleSpy.Core.Models;
using SaleSpy.Core.Services;
using SaleSpy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task<List<ArticleSale>> GetAllArticleSales()
        {
            return await _saleSpyDbContext.ArticleSales.ToListAsync();
        }
    }
}
