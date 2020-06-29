using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Note.API.Model;

namespace Note.API.Infrastructure
{
    public class NoteContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "note";

        public DbSet<Entry> Notebooks { get; set; } 

        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {
        }

    }
}
