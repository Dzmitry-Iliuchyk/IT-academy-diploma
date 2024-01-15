namespace HW_cookie_autentification.Models.ShopModels
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; } = null!;
        public List<OrderProduct> OrderProduct { get; set; } = null!;
    }
}
