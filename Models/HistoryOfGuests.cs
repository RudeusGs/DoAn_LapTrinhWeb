namespace DragonAcc.Models
{
    public class HistoryOfGuests:BaseModel
    {
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int ServiceID { get; set; }
        public int TotalAmount { get; set; }

    }
}
