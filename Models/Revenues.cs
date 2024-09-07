namespace DragonAcc.Models
{
    public class Revenues : BaseModel
    {
        public int UserId { get; set; }

        public int RevenueByWeek { get; set; }
        public int RevenueBymonth { get; set; }
        public int RevenueByYear { get; set; }
    }
}
