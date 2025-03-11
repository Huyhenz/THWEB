using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanSet.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
