﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mix.Database.Migrations.SqlServerMixCms
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MixSite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    SystemName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixSite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MixConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false),
                    SystemName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixConfiguration_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixCulture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    Alias = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Icon = table.Column<string>(type: "nvarchar(4000)", nullable: true),
                    Lcid = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Specificulture = table.Column<string>(type: "nvarchar(50)", nullable: true, collation: "Vietnamese_CI_AS"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixCulture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixCulture_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false),
                    SystemName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixDatabase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixDatabase_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixDomain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixDomain_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false),
                    SystemName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixLanguage_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixModule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "varchar(250)", nullable: false, collation: "utf8_unicode_ci"),
                    Description = table.Column<string>(type: "varchar(4000)", nullable: true, collation: "utf8_unicode_ci"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false),
                    SystemName = table.Column<string>(type: "varchar(250)", nullable: false, collation: "utf8_unicode_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixModule_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MixSiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixPost_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixUrlAlias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixUrlAlias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixUrlAlias_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixConfigurationContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    DefaultContent = table.Column<string>(type: "nvarchar(4000)", nullable: false, collation: "Vietnamese_CI_AS"),
                    MixConfigurationId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    SystemName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Content = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixConfigurationContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixConfigurationContent_MixConfiguration_MixConfigurationId",
                        column: x => x.MixConfigurationId,
                        principalTable: "MixConfiguration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixConfigurationContent_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixDataContentAssociation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    MixDatabaseId = table.Column<int>(type: "int", nullable: false),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DataContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IntParentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixDataContentAssociation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixDataContentAssociation_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    MixDatabaseId = table.Column<int>(type: "int", nullable: false),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixData_MixDatabase_MixDatabaseId",
                        column: x => x.MixDatabaseId,
                        principalTable: "MixDatabase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixDatabaseColumn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    SystemName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    DataType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Configurations = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    ReferenceId = table.Column<int>(type: "int", nullable: true),
                    DefaultValue = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixDatabaseId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixDatabaseColumn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixDatabaseColumn_MixDatabase_MixDatabaseId",
                        column: x => x.MixDatabaseId,
                        principalTable: "MixDatabase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixLanguageContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    DefaultContent = table.Column<string>(type: "nvarchar(4000)", nullable: false, collation: "Vietnamese_CI_AS"),
                    MixLanguageId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    SystemName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Content = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixLanguageContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixLanguageContent_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixLanguageContent_MixLanguage_MixLanguageId",
                        column: x => x.MixLanguageId,
                        principalTable: "MixLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MixUrlAliasContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    SourceId = table.Column<string>(type: "nvarchar(50)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Alias = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    MixUrlAliasId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixUrlAliasContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixUrlAliasContent_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixUrlAliasContent_MixUrlAlias_MixUrlAliasId",
                        column: x => x.MixUrlAliasId,
                        principalTable: "MixUrlAlias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MixDataContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    MixDatabaseId = table.Column<int>(type: "int", nullable: false),
                    MixDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Content = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    Layout = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Template = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Image = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Source = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoDescription = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoKeywords = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoName = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixDataContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MixDataContentId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixDataContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixDataContent_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixDataContent_MixData_MixDataId",
                        column: x => x.MixDataId,
                        principalTable: "MixData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixDataContent_MixDataContent_MixDataContentId1",
                        column: x => x.MixDataContentId1,
                        principalTable: "MixDataContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MixDataContentValue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    MixDatabaseColumnName = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    DataType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BooleanValue = table.Column<bool>(type: "bit", nullable: true),
                    DateTimeValue = table.Column<DateTime>(type: "datetime", nullable: true),
                    DoubleValue = table.Column<double>(type: "float", nullable: true),
                    IntegerValue = table.Column<int>(type: "int", nullable: true),
                    StringValue = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    EncryptValue = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    EncryptKey = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    EncryptType = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    MixDataContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MixDatabaseColumnId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixDataContentValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixDataContentValue_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixDataContentValue_MixDatabaseColumn_MixDatabaseColumnId",
                        column: x => x.MixDatabaseColumnId,
                        principalTable: "MixDatabaseColumn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixDataContentValue_MixDataContent_MixDataContentId",
                        column: x => x.MixDataContentId,
                        principalTable: "MixDataContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixModuleContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    SystemName = table.Column<string>(type: "varchar(250)", nullable: true),
                    ClassName = table.Column<string>(type: "varchar(50)", nullable: true),
                    PageSize = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", nullable: false),
                    MixModuleId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Content = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    Layout = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Template = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Image = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Source = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoDescription = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoKeywords = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoName = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixDataContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixModuleContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixModuleContent_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixModuleContent_MixDataContent_MixDataContentId",
                        column: x => x.MixDataContentId,
                        principalTable: "MixDataContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixModuleContent_MixModule_MixModuleId",
                        column: x => x.MixModuleId,
                        principalTable: "MixModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MixTheme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    PreviewUrl = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MixDataContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixTheme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixTheme_MixDataContent_MixDataContentId",
                        column: x => x.MixDataContentId,
                        principalTable: "MixDataContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixTheme_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixViewTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    Content = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    Extension = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    FileFolder = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    FileName = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    FolderType = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Scripts = table.Column<string>(type: "ntext", nullable: false, collation: "Vietnamese_CI_AS"),
                    SpaContent = table.Column<string>(type: "ntext", nullable: false, collation: "Vietnamese_CI_AS"),
                    MobileContent = table.Column<string>(type: "ntext", nullable: false, collation: "Vietnamese_CI_AS"),
                    Styles = table.Column<string>(type: "ntext", nullable: false, collation: "Vietnamese_CI_AS"),
                    MixThemeName = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    MixThemeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixViewTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixViewTemplate_MixTheme_MixThemeId",
                        column: x => x.MixThemeId,
                        principalTable: "MixTheme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixPageContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    ClassName = table.Column<string>(type: "varchar(50)", nullable: true),
                    PageSize = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", nullable: false),
                    MixPageId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Content = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    Layout = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Template = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Image = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Source = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoDescription = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoKeywords = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoName = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixDataContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixPageContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixPageContent_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixPageContent_MixDataContent_MixDataContentId",
                        column: x => x.MixDataContentId,
                        principalTable: "MixDataContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MixPostContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    ClassName = table.Column<string>(type: "varchar(50)", nullable: true),
                    MixPostId = table.Column<int>(type: "int", nullable: true),
                    MixModuleContentId = table.Column<int>(type: "int", nullable: true),
                    MixPageContentId = table.Column<int>(type: "int", nullable: true),
                    MixPostContentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specificulture = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "Vietnamese_CI_AS"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    MixCultureId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Content = table.Column<string>(type: "ntext", nullable: true, collation: "Vietnamese_CI_AS"),
                    Layout = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Template = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Image = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    Source = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoDescription = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoKeywords = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoName = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MixDatabaseName = table.Column<string>(type: "nvarchar(250)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixDataContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixPostContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixPostContent_MixCulture_MixCultureId",
                        column: x => x.MixCultureId,
                        principalTable: "MixCulture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixPostContent_MixDataContent_MixDataContentId",
                        column: x => x.MixDataContentId,
                        principalTable: "MixDataContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixPostContent_MixModuleContent_MixModuleContentId",
                        column: x => x.MixModuleContentId,
                        principalTable: "MixModuleContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixPostContent_MixPageContent_MixPageContentId",
                        column: x => x.MixPageContentId,
                        principalTable: "MixPageContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixPostContent_MixPost_MixPostId",
                        column: x => x.MixPostId,
                        principalTable: "MixPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixPostContent_MixPostContent_MixPostContentId",
                        column: x => x.MixPostContentId,
                        principalTable: "MixPostContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MixPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEWID()"),
                    MixPostContentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", nullable: false, collation: "Vietnamese_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(4000)", nullable: true, collation: "Vietnamese_CI_AS"),
                    MixSiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixPage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MixPage_MixPostContent_MixPostContentId",
                        column: x => x.MixPostContentId,
                        principalTable: "MixPostContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixPage_MixSite_MixSiteId",
                        column: x => x.MixSiteId,
                        principalTable: "MixSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MixConfiguration_MixSiteId",
                table: "MixConfiguration",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixConfigurationContent_MixConfigurationId",
                table: "MixConfigurationContent",
                column: "MixConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_MixConfigurationContent_MixCultureId",
                table: "MixConfigurationContent",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixCulture_MixSiteId",
                table: "MixCulture",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixData_MixDatabaseId",
                table: "MixData",
                column: "MixDatabaseId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDatabase_MixSiteId",
                table: "MixDatabase",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDatabaseColumn_MixDatabaseId",
                table: "MixDatabaseColumn",
                column: "MixDatabaseId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDataContent_MixCultureId",
                table: "MixDataContent",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDataContent_MixDataContentId1",
                table: "MixDataContent",
                column: "MixDataContentId1");

            migrationBuilder.CreateIndex(
                name: "IX_MixDataContent_MixDataId",
                table: "MixDataContent",
                column: "MixDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDataContentAssociation_MixCultureId",
                table: "MixDataContentAssociation",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDataContentValue_MixCultureId",
                table: "MixDataContentValue",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDataContentValue_MixDatabaseColumnId",
                table: "MixDataContentValue",
                column: "MixDatabaseColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDataContentValue_MixDataContentId",
                table: "MixDataContentValue",
                column: "MixDataContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixDomain_MixSiteId",
                table: "MixDomain",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixLanguage_MixSiteId",
                table: "MixLanguage",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixLanguageContent_MixCultureId",
                table: "MixLanguageContent",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixLanguageContent_MixLanguageId",
                table: "MixLanguageContent",
                column: "MixLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MixModule_MixSiteId",
                table: "MixModule",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixModuleContent_MixCultureId",
                table: "MixModuleContent",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixModuleContent_MixDataContentId",
                table: "MixModuleContent",
                column: "MixDataContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixModuleContent_MixModuleId",
                table: "MixModuleContent",
                column: "MixModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPage_MixPostContentId",
                table: "MixPage",
                column: "MixPostContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPage_MixSiteId",
                table: "MixPage",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPageContent_MixCultureId",
                table: "MixPageContent",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPageContent_MixDataContentId",
                table: "MixPageContent",
                column: "MixDataContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPageContent_MixPageId",
                table: "MixPageContent",
                column: "MixPageId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPost_MixSiteId",
                table: "MixPost",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPostContent_MixCultureId",
                table: "MixPostContent",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPostContent_MixDataContentId",
                table: "MixPostContent",
                column: "MixDataContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPostContent_MixModuleContentId",
                table: "MixPostContent",
                column: "MixModuleContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPostContent_MixPageContentId",
                table: "MixPostContent",
                column: "MixPageContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPostContent_MixPostContentId",
                table: "MixPostContent",
                column: "MixPostContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixPostContent_MixPostId",
                table: "MixPostContent",
                column: "MixPostId");

            migrationBuilder.CreateIndex(
                name: "IX_MixTheme_MixDataContentId",
                table: "MixTheme",
                column: "MixDataContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixTheme_MixSiteId",
                table: "MixTheme",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixUrlAlias_MixSiteId",
                table: "MixUrlAlias",
                column: "MixSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_MixUrlAliasContent_MixCultureId",
                table: "MixUrlAliasContent",
                column: "MixCultureId");

            migrationBuilder.CreateIndex(
                name: "IX_MixUrlAliasContent_MixUrlAliasId",
                table: "MixUrlAliasContent",
                column: "MixUrlAliasId");

            migrationBuilder.CreateIndex(
                name: "IX_MixViewTemplate_MixThemeId",
                table: "MixViewTemplate",
                column: "MixThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MixPageContent_MixPage_MixPageId",
                table: "MixPageContent",
                column: "MixPageId",
                principalTable: "MixPage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MixCulture_MixSite_MixSiteId",
                table: "MixCulture");

            migrationBuilder.DropForeignKey(
                name: "FK_MixDatabase_MixSite_MixSiteId",
                table: "MixDatabase");

            migrationBuilder.DropForeignKey(
                name: "FK_MixModule_MixSite_MixSiteId",
                table: "MixModule");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPage_MixSite_MixSiteId",
                table: "MixPage");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPost_MixSite_MixSiteId",
                table: "MixPost");

            migrationBuilder.DropForeignKey(
                name: "FK_MixDataContent_MixCulture_MixCultureId",
                table: "MixDataContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixModuleContent_MixCulture_MixCultureId",
                table: "MixModuleContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPageContent_MixCulture_MixCultureId",
                table: "MixPageContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPostContent_MixCulture_MixCultureId",
                table: "MixPostContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixData_MixDatabase_MixDatabaseId",
                table: "MixData");

            migrationBuilder.DropForeignKey(
                name: "FK_MixDataContent_MixData_MixDataId",
                table: "MixDataContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixModuleContent_MixDataContent_MixDataContentId",
                table: "MixModuleContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPageContent_MixDataContent_MixDataContentId",
                table: "MixPageContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPostContent_MixDataContent_MixDataContentId",
                table: "MixPostContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixModuleContent_MixModule_MixModuleId",
                table: "MixModuleContent");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPage_MixPostContent_MixPostContentId",
                table: "MixPage");

            migrationBuilder.DropTable(
                name: "MixConfigurationContent");

            migrationBuilder.DropTable(
                name: "MixDataContentAssociation");

            migrationBuilder.DropTable(
                name: "MixDataContentValue");

            migrationBuilder.DropTable(
                name: "MixDomain");

            migrationBuilder.DropTable(
                name: "MixLanguageContent");

            migrationBuilder.DropTable(
                name: "MixUrlAliasContent");

            migrationBuilder.DropTable(
                name: "MixViewTemplate");

            migrationBuilder.DropTable(
                name: "MixConfiguration");

            migrationBuilder.DropTable(
                name: "MixDatabaseColumn");

            migrationBuilder.DropTable(
                name: "MixLanguage");

            migrationBuilder.DropTable(
                name: "MixUrlAlias");

            migrationBuilder.DropTable(
                name: "MixTheme");

            migrationBuilder.DropTable(
                name: "MixSite");

            migrationBuilder.DropTable(
                name: "MixCulture");

            migrationBuilder.DropTable(
                name: "MixDatabase");

            migrationBuilder.DropTable(
                name: "MixData");

            migrationBuilder.DropTable(
                name: "MixDataContent");

            migrationBuilder.DropTable(
                name: "MixModule");

            migrationBuilder.DropTable(
                name: "MixPostContent");

            migrationBuilder.DropTable(
                name: "MixModuleContent");

            migrationBuilder.DropTable(
                name: "MixPageContent");

            migrationBuilder.DropTable(
                name: "MixPost");

            migrationBuilder.DropTable(
                name: "MixPage");
        }
    }
}