using System;
using Microsoft.EntityFrameworkCore;
using Note.Domain.AggregatesModel.NotebookAggregate;
using Note.Infrastructure.EntityConfigurations;

namespace Note.Infrastructure
{
    public class NoteContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "note";

        public DbSet<Entry> Entries { get; set; }

        public DbSet<Notebook> Notebooks { get; set; }

        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new NotebookEntityTypeConfiguration());
        }
    }
}
