namespace DragonAcc.Models
{
    public class HistoryOfSellers:BaseModel
    {
        public int UserID { get; set; }
        public int SellerID { get; set; }

        public int? ProductID { get; set; }
        public int? ServiceID { get; set; }
        public double TotalAmount { get; set; }

    }
}
