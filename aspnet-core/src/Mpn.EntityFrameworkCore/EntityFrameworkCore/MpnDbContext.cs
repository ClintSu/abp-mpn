using Microsoft.EntityFrameworkCore;
using Mpn.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Mpn.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See MpnMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class MpnDbContext : AbpDbContext<MpnDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside MpnDbContextModelCreatingExtensions.ConfigureMpn
         */

        public MpnDbContext(DbContextOptions<MpnDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the MpnEfCoreEntityExtensionMappings class
                 */
                b.Property<string>(p => p.IdCard).HasColumnName("IdCard").HasColumnType("nvarchar(20)");
                b.Property<string>(p => p.Address).HasColumnName("Address").HasColumnType("nvarchar(256)");
                b.Property<string>(p => p.DingTalk).HasColumnName("DingTalk").HasColumnType("nvarchar(64)");
                b.Property<string>(p => p.WetChat).HasColumnName("WetChat").HasColumnType("nvarchar(64)");

            });

            /* Configure your own tables/entities inside the ConfigureMpn method */

            builder.ConfigureMpn();
        }
    }
}
