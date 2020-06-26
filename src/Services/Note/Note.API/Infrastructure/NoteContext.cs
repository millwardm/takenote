using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Note.API.Model;

namespace Note.API.Infrastructure
{
    public class NoteContext : DbContext
    {
        public DbSet<Notebook> Notebooks { get; set; } 

        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {
        }

    }
}
