﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mix.Database.Entities.Account;
using Mix.Lib.Extensions;
using Mix.Shared.Services;
using System.Reflection;

namespace Mix.Identity.Abstracts
{
    public abstract class IdentityStartupModule
    {
        public IdentityStartupModule(IConfiguration configuration, Assembly assembly)
        {
            Configuration = configuration;
            Assembly = assembly;
        }

        public IConfiguration Configuration { get; }
        public Assembly Assembly { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMixServices(Assembly, Configuration);

            // Must app Auth config after Add mixservice to init App config 
            services.AddMixAuthorize<ApplicationDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MixAppSettingService appSettingService)
        {
            app.UseMixApps(Assembly.GetExecutingAssembly(), Configuration, env.IsDevelopment(), appSettingService);
        }
    }
}