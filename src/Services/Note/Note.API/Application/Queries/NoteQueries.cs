using System;
using System.Threading.Tasks;
using Note.Domain.AggregatesModel.NotebookAggregate;
using Note.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Dapper;

namespace Note.API.Application.Queries
{
    public class NoteQueries : INoteQueries
    {

        private string _connectionString = string.Empty;

        public NoteQueries(String conStr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(conStr) ? conStr : throw new ArgumentNullException(nameof(conStr));
        }

        public async Task<IEnumerable<Notebook>> GetNotebooksAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return await connection.QueryAsync<Notebook>(
                   @"select id, name from note.notebook"
                );

            }
        }
    }
}
