using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Note.API.Infrastructure;
using Note.API.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Note.API.Controllers
{
    [ApiController]
    [Route("note")]
    public class NoteController : ControllerBase
    {
        private readonly ILogger<NoteController> _logger;
        private NoteContext _context;

        public NoteController(ILogger<NoteController> logger, NoteContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public String Get()
        {

            /*
            _context.Notebooks.Add(new Notebook { Name = "My new notebook" });
            _context.SaveChanges();

            foreach (var blog in _context.Notebooks)
            {
                Console.WriteLine(blog.Name);
            }*/
           
            return "Hello World!";
        }

    }
}
