using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
