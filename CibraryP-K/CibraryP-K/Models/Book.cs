using System.Collections.Generic;

namespace CibraryP_K.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
        public virtual ICollection<BookCategory> Categories { get; set; }
    }
}