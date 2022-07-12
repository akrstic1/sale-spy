using SaleSpy.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SaleSpy.Core.Resources.Request
{
    public class CreateArticleSaleResource
    {
        [Required]
        [MaxLength(32)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only alphanumeric characters are allowed.")]
        public string ArticleNumber { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Price can't be negative.")]
        [RegularExpression(@"^[0-9]*(\\.[0-9]{1,2})?$", ErrorMessage = "Invalid currency format.")]
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
