using AdminToUserMailAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminToUserMailAPI.Services
{
    public class MesDb : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Recipient> Recipients { get; set; }

        public MesDb(DbContextOptions<MesDb> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
