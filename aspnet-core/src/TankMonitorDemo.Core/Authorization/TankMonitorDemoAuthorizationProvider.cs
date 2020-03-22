﻿using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace TankMonitorDemo.Authorization
{
    public class TankMonitorDemoAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Products, L("Products"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TankMonitorDemoConsts.LocalizationSourceName);
        }
    }
}
