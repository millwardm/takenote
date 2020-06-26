using System;
using Note.API.Model;

namespace Note.API.Infrastructure
{
    public class NotebookRepository : INotebookRepository
    {
        private NoteContext _context;

        public NotebookRepository(NoteContext context)
        {
            context = _context;
        }
    }
}
