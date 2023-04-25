using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace To_do_list_websit.models.mytask
{
    public class taskconfigration : IEntityTypeConfiguration<tasks>
    {
        public void Configure(EntityTypeBuilder<tasks> builder)
        {
            builder.ToTable("tasks");
            builder.HasKey(i => i.id);
            builder.Property(i => i.id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.name).IsRequired().HasMaxLength(50);
            
        }
    }
}
