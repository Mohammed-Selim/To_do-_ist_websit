using Microsoft.EntityFrameworkCore;
using To_do_list_websit.models.mytask;

namespace To_do_list_websit.models
{
    public static class relations
    {
        public static void myrelation(this ModelBuilder builder)
        {
            builder.Entity<tasks>().HasOne(a => a.user).WithMany(a => a.tasks)
            .HasForeignKey(a => a.Userid).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<tasks>().HasOne(a => a.Category).WithMany(a => a.tasks)
           .HasForeignKey(a => a.Categoryid).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
