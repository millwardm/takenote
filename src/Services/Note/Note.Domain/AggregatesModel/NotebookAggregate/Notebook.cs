using System;
namespace Note.Domain.AggregatesModel.NotebookAggregate
{
    public class Notebook
    {
        public int Id { get; private set; }

        public String _name;

        public Notebook(String name)
        {
            _name = name;
        }

    }
}
