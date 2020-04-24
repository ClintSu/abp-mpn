using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Mpn.EntityFrameworkCore
{
    public static class MpnDbContextModelCreatingExtensions
    {
        public static void ConfigureMpn(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MpnConsts.DbTablePrefix + "YourEntities", MpnConsts.DbSchema);

            //    //...
            //});
        }
    }
}