namespace HW_cookie_autentification.Models.ShopModels
{
    public class Client : BaseEntity
    {
        public string Name { get; set; } = null!;
        
        public List<Order>? Orders { get; set; }
    }
}
