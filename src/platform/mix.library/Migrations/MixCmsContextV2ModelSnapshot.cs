﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Mix.Database.Entities.Cms.v2;

namespace Mix.Lib.Migrations
{
    [DbContext(typeof(MixCmsContextV2))]
    partial class MixCmsContextV2ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Mix.Lib.Entities.Cms.v2.MixPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MixPages");
                });

            modelBuilder.Entity("Mix.Lib.Entities.Cms.v2.MixPageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("CssClass")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ExternalDataId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExternalDatbaseName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Layout")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MixPageId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PageSize")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SeoDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeoKeywords")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeoName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeoTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specificulture")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SystemName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Template")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MixPageId");

                    b.ToTable("MixPageContents");
                });

            modelBuilder.Entity("Mix.Lib.Entities.Cms.v2.MixPageContent", b =>
                {
                    b.HasOne("Mix.Lib.Entities.Cms.v2.MixPage", null)
                        .WithMany("MixPageContents")
                        .HasForeignKey("MixPageId");
                });

            modelBuilder.Entity("Mix.Lib.Entities.Cms.v2.MixPage", b =>
                {
                    b.Navigation("MixPageContents");
                });
#pragma warning restore 612, 618
        }
    }
}