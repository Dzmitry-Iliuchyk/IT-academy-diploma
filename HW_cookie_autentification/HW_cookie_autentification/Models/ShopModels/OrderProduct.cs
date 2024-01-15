namespace HW_cookie_autentification.Models.ShopModels
{
    public class OrderProduct : BaseEntity
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; } = null!;
        public Order Order { get; set; } = null!;
    }
}
