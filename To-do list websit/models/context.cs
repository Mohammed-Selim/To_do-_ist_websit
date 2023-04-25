using Microsoft.EntityFrameworkCore;
using To_do_list_websit.models.categorys;
using To_do_list_websit.models.user;
using To_do_list_websit.models.mytask;
using To_do_list_websit.models.DTOs;

namespace To_do_list_websit.models
{
    public class context : DbContext
    {
        public DbSet<tasks> tasks { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Users> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
          "Data Source=.;Initial Catalog=To_do_listDB; Integrated Security=True; TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new userconfigration().Configure(modelBuilder.Entity<Users>());
            new CategoryConfigration().Configure(modelBuilder.Entity<Category>());
            new taskconfigration().Configure(modelBuilder.Entity<tasks>());

            modelBuilder.myrelation();
        }
        public DbSet<To_do_list_websit.models.DTOs.TaskDto> TaskDto { get; set; } = default!;

    }
}
