using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Note.Domain.AggregatesModel.NotebookAggregate;
using Note.Infrastructure;

namespace Note.API.Application.Commands
{
    public class CreateNotebookCommandHandler : IRequestHandler<CreateNotebookCommand, bool>
    {
        private NoteContext _noteContext;

        public CreateNotebookCommandHandler(NoteContext noteContext)
        {
            _noteContext = noteContext;
        }

        public async Task<bool> Handle(CreateNotebookCommand command, CancellationToken cancellationToken)
        {
            // TODO: validate that a notebook doesn't already exist
            Notebook notebook = new Notebook(command.Name);

            _noteContext.Notebooks.Add(notebook);

            int records = await _noteContext.SaveChangesAsync(cancellationToken);

            return records == 1;

        }
    }
}
