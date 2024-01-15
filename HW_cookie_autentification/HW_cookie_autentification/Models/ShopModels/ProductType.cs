namespace HW_cookie_autentification.Models.ShopModels
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<Product>? Products { get; set; }
    }
}
