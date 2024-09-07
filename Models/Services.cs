namespace DragonAcc.Models
{
    public class Services : BaseModel
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int server {  get; set; }
        public int ProductID { get; set; }
        public double GemQuantity { get; set; }
        public double CoinQuantity { get; set; }
        public double Coefficient { get; set; }
        public double UnitPrice { get; set; }
    }
}
