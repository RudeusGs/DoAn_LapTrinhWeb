﻿namespace DragonAcc.Models
{
    public class Account : BaseModel
    {
        public int UserID { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
            
        public string Name { get; set; }
        public int? Status { get; set; }


    }
}
