﻿using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace Mpn.EntityFrameworkCore
{
    public static class MpnEfCoreEntityExtensionMappings
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                /* You can configure entity extension properties for the
                 * entities defined in the used modules.
                 *
                 * The properties defined here becomes table fields.
                 * If you want to use the ExtraProperties dictionary of the entity
                 * instead of creating a new field, then define the property in the
                 * MpnDomainObjectExtensions class.
                 *
                 * Example:
                 *
                 * ObjectExtensionManager.Instance
                 *    .MapEfCoreProperty<IdentityUser, string>(
                 *        "MyProperty",
                 *        b => b.HasMaxLength(128)
                 *    );
                 *
                 * See the documentation for more:
                 * https://docs.abp.io/en/abp/latest/Customizing-Application-Modules-Extending-Entities
                 */



                ObjectExtensionManager.Instance.MapEfCoreProperty<IdentityUser, string>("IdCard", b => b.HasMaxLength(20));
                ObjectExtensionManager.Instance.MapEfCoreProperty<IdentityUser, string>("Address", b => b.HasMaxLength(256));
                ObjectExtensionManager.Instance.MapEfCoreProperty<IdentityUser, string>("DingTalk", b => b.HasMaxLength(64));
                ObjectExtensionManager.Instance.MapEfCoreProperty<IdentityUser, string>("WetChat", b => b.HasMaxLength(64));
            });
        }
    }
}