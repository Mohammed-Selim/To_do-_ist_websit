using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace To_do_list_websit.models.user
{
    public class userconfigration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {

            builder.ToTable("user");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Name).IsRequired().HasMaxLength(50);
        }
    }
}
