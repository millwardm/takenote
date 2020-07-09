using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Note.FunctionalTests
{
    public class NoteScenarios 
    {
        [Fact]
        public async Task Get_Notebooks()
        {
            using (var client = new HttpClient())
            {
                var valuesEndpoint = "http://note.api/note";

                var response = await client.GetAsync(valuesEndpoint);

                Console.WriteLine("STATUS CODE: " + response.StatusCode);

                Console.WriteLine(response.Content.ToString());

                response.EnsureSuccessStatusCode();

            }
        }

    }
}
