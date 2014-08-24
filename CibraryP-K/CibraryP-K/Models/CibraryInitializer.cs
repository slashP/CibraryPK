using System;
using System.Data.Entity;

namespace CibraryP_K.Models
{
    public class CibraryInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
            const string email = "perkristianhelland@gmail.com";
            context.Users.Add(new ApplicationUser
            {
                Email = email,
                PasswordHash = "ADyYNhHNMI3U3ApIxPy6uhX3mE+NvWlbkl2u8Jz4B05u+2bBDhOCZQZI74ITS66oUw==",
                Id = Guid.NewGuid().ToString(),
                UserName = email,
                SecurityStamp = "asdfasdfasdasdf"
            });
        }
    }
}