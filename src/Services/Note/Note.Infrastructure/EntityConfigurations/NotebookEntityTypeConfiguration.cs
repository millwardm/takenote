using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Note.Domain.AggregatesModel.NotebookAggregate;

namespace Note.Infrastructure.EntityConfigurations
{
    public class NotebookEntityTypeConfiguration : IEntityTypeConfiguration<Notebook>
    {
        public void Configure(EntityTypeBuilder<Notebook> notebookConfiguration)
        {
            notebookConfiguration.ToTable("notebook", NoteContext.DEFAULT_SCHEMA);

            notebookConfiguration.HasKey(o => o.Id);

            notebookConfiguration
                .Property<string>("_name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Name")
                .IsRequired();
        }
    }
}
