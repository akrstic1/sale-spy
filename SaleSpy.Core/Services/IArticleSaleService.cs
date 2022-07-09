using SaleSpy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleSpy.Core.Services
{
    public interface IArticleSaleService
    {
        Task<List<ArticleSale>> GetAllArticleSales();
    }
}
