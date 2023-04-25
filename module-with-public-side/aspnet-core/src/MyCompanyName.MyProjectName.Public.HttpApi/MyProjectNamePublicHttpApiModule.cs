﻿using Localization.Resources.AbpUi;
using MyCompanyName.MyProjectName.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MyCompanyName.MyProjectName;

[DependsOn(
    typeof(MyProjectNamePublicApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class MyProjectNamePublicHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(MyProjectNamePublicHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<MyProjectNameResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
