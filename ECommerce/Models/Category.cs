namespace ECommerce.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The field {0} must be maximun {1} characters length")]        
        [Index("Category_Description_Index", 2, IsUnique = true)]
        [Display(Name = "Category")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]  
        [Display(Name = "Company")]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}