using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CibraryP_K.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>()
                .HasMany(x => x.Categories)
                .WithMany(x => x.Books)
                .Map(x => x.ToTable("BookInCategory").MapLeftKey("Book_Id").MapRightKey("Category_Id"));
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}