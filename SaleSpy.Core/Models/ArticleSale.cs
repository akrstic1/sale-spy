using System;
using System.ComponentModel.DataAnnotations;

namespace SaleSpy.Core.Models
{
    public class ArticleSale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        public string ArticleNumber { get; set; }
        [Required]
        public decimal SalesPrice { get; set; }
        public DateTime SoldOn { get; set; }
    }
}
