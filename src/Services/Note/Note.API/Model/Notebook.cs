using System;
using System.Collections.Generic;

namespace Note.API.Model
{
    public class Notebook
    {
        public int ID { get; set; }
        public String Name { get; set; } 

        /**
        private readonly List<Note> _notes  ; 
        public IReadOnlyCollection<Note> Notes => _notes;
        **/

        public Notebook()
        {
        }
    }
}
