﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mix.Lib.Enums;
using Mix.Lib.Entities.Cms;

namespace Mix.Lib.Entities.EntityConfigurations.MySQL
{
    public class MixConfigurationConfiguration : IEntityTypeConfiguration<MixConfiguration>
    {
        public void Configure(EntityTypeBuilder<MixConfiguration> entity)
        {
            entity.HasKey(e => new { e.Id, e.Specificulture })
                    .HasName("PRIMARY");

            entity.ToTable("mix_configuration");

            entity.HasIndex(e => e.Specificulture);

            entity.Property(e => e.Specificulture)
                .HasColumnType("varchar(10)")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.Category)
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.Keyword)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.LastModified).HasColumnType("datetime");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<MixContentStatus>())
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<MixDataType>())
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            entity.HasOne(d => d.SpecificultureNavigation)
                .WithMany(p => p.MixConfiguration)
                .HasPrincipalKey(p => p.Specificulture)
                .HasForeignKey(d => d.Specificulture)
                .HasConstraintName("FK_Mix_Configuration_Mix_Culture");
        }
    }
}