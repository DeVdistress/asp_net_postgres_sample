using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace web_api.Database.Configurations;

public class UserCfg : IEntityTypeConfiguration<web_api.Database.Models.UserMod>
{
    public void Configure(EntityTypeBuilder<web_api.Database.Models.UserMod> builder)
    {
        throw new NotImplementedException();
    }
}