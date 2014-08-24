using System.Collections.Generic;

namespace CibraryP_K.Models
{
    public class BookCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}