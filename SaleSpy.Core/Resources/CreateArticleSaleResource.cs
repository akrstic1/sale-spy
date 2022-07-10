using SaleSpy.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleSpy.Core.Resources
{
    public class CreateArticleSaleResource
    {
        [Required]
        [MaxLength(32)]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        public string ArticleNumber { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal SalesPrice { get; set; }

        public static ArticleSale ToArticleSale(CreateArticleSaleResource articleSaleDto)
        {
            return new ArticleSale
            {
                ArticleNumber = articleSaleDto.ArticleNumber,
                SalesPrice = articleSaleDto.SalesPrice,
                SoldOn = DateTime.Now
            };
        }
    }
}
