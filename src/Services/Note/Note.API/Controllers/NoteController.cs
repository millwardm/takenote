using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Note.API.Application.Commands;
using Note.API.Application.Queries;

namespace Note.API.Controllers
{
    [ApiController]
    [Route("note")]
    public class NoteController : ControllerBase
    {
        private readonly ILogger<NoteController> _logger;

        private IMediator _mediator;

        private INoteQueries _queries;

        public NoteController(ILogger<NoteController> logger, IMediator mediator, INoteQueries queries)
        {
            _logger = logger;
            _mediator = mediator;
            _queries = queries;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Notebook>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Notebook>>> GetNotebooks()
        {
            var notebooks = await _queries.GetNotebooksAsync();
            return Ok(notebooks);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> CreateNotebook([FromBody] CreateNotebookCommand createNotebookCommand)
        {
            var commandResult = await _mediator.Send(createNotebookCommand);
            return commandResult ? (ActionResult)Ok() : (ActionResult)BadRequest();
        }


    }
}
