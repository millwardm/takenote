using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Note.API.Application.Queries
{
    public interface INoteQueries
    {

        public Task<IEnumerable<Notebook>> GetNotebooksAsync();

    }
}
