using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace web_api.Database.Configurations;

public class UserCfg : IEntityTypeConfiguration<web_api.Database.Models.UserMod>
{
    public void Configure(EntityTypeBuilder<web_api.Database.Models.UserMod> builder)
    {
        builder.ToTable("users");
        
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .HasColumnName("id")
            .HasColumnType("int")
            .IsRequired();
        
        builder.Property(p => p.Age)
            .HasColumnName("age")
            .HasColumnType("int")
            .IsRequired();
        
        builder.Property(p => p.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(255)")
            .HasMaxLength(255)
            .IsRequired();
    }
}