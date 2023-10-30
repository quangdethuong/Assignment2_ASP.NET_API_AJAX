using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EstoreAjaxIden.Models
{
    public class Product
    {

        public int ProductId { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category Name")]
        public int? CategoryId { get; set; }

        [Display(Name = "Product Name")]

        [Required(ErrorMessage = "ProductName is required")]
        [MaxLength(100)]
        public string ProductName { get; set; }
        [Display(Name = "Weight (gram)")]

        public double Weight { get; set; }

        [Range(0, double.MaxValue)]
        [Display(Name = "Unit Price ($)")]

        public decimal UnitPrice { get; set; }
        [Required]
        [Display(Name = "Unit In Stock")]
        public int UnitsInStock { get; set; }

    }
}
