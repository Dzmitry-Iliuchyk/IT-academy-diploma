namespace HW_cookie_autentification.Models.ShopModels
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Modify { get; set; }
    }
}
