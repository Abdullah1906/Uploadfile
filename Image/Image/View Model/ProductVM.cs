namespace Image.View_Model
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile Image { get; set; }
        public int price { get; set; }
    }
}
