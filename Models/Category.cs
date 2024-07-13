using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulkyweb.Models
{
    public class Category
    {
        public int Id { get; set; } // ID and ClassnameId(CategoryId) is Primary Key by convention no need to specify [key].
        [Required]
        [DisplayName("Category Name")]
        public String name { get; set; }
        [Required]
        [DisplayName("Category Description")]
        [MaxLength(50, ErrorMessage= "Description must be of maxLength 50")]
        public String description { get; set; }
    }
}