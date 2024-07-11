using System.ComponentModel.DataAnnotations;

namespace Bulkyweb.Models
{
    public class Category
    {
        public int Id { get; set; } // ID and ClassnameId(CategoryId) is Primary Key by convention no need to specify [key].
        [Required]
        public String name { get; set; }
        public String description { get; set; }
    }
}