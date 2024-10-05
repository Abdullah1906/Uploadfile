using System.ComponentModel.DataAnnotations;

namespace Image.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int price { get; set; }
    }
}
