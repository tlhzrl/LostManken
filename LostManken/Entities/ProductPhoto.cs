namespace LostManken.Entities
{
    public class ProductPhoto
    {
        public int Id { get; set; }
        public string OrginalFileName { get; set; }
        public string FileUrl { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}