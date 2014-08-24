using System;

namespace CibraryP_K.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime TimeLoaned { get; set; }
        public DateTime? TimeDelivered { get; set; }
        public virtual  Book Book { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}