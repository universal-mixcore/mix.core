﻿using Microsoft.EntityFrameworkCore;
using Mix.Database.Entities.Cms.v2;
using Mix.Database.EntityConfigurations.v2.SQLITE;
using Mix.Database.Services;
using Mix.Shared.Services;

namespace Mix.Database.Entities.v2
{
    public class SqliteMixCmsContext : MixCmsContext
    {
        public SqliteMixCmsContext(MixDatabaseService databaseService, MixAppSettingService appSettingService) 
            : base(databaseService, appSettingService)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(
                this.GetType().Assembly, 
                m=> m.Namespace == typeof(SqliteDatabaseConstants).Namespace);
        }
    }
}