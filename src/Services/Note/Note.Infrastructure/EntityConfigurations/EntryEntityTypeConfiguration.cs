using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Note.Domain.AggregatesModel.NotebookAggregate;

namespace Note.Infrastructure.EntityConfigurations
{
    public class EntryEntityTypeConfiguration : IEntityTypeConfiguration<Entry>
    {
        public void Configure(EntityTypeBuilder<Entry> entryConfiguration)
        {
            entryConfiguration.ToTable("entry", NoteContext.DEFAULT_SCHEMA);

            entryConfiguration.HasKey(o => o.Id);

            entryConfiguration
                .Property<string>("_content")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Content")
                .IsRequired();


        }
    }
}
