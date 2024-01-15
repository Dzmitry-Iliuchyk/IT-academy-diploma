namespace HW_cookie_autentification.Models.ShopModels
{
    public class Order : BaseEntity
    {
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;
        public string? Name { get; set; }
        public List<OrderProduct> OrderProducts { get; set; } = null!;
    }
}
