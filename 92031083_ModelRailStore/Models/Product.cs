using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _92031083_ModelRailStore.Models
{
    public partial class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The Product Name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s]*$", ErrorMessage = "Please enter a product name made up of only letters and spaces.")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Product Year cannot be blank")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Please enter a product year four numbers in length")]
        [RegularExpression(@"^(19|20)\d{2}$", ErrorMessage = "Please enter a product year between 1900 - 2099.")]
        [Display(Name = "Year")]
        public string Year { get; set; }

        [Required(ErrorMessage = "The Product Description cannot be blank")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter a product description between 10 and 200 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s]*$", ErrorMessage = "Please enter a product description made up of only letters and spaces.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Product price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage = "Please enter a product price between 0.10 and 10000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ProductImageMapping> ProductImageMappings { get; set; }
    }
}