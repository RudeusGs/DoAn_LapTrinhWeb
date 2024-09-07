namespace DragonAcc.Models
{
    public class ServiceDetails : BaseModel
    {
        public int ServiceDetailID { get; set; }
        public int ServiceID { get; set; }
        public bool Status { get; set; }
    }
}
