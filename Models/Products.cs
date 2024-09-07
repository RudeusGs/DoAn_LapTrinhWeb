namespace DragonAcc.Models
{
    public class Product : BaseModel
    {    
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double UnitPrice { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public bool? RegisterType { get; set; }
        public bool? capsule { get; set; }
        public int? planet { get; set; }
    }
}
