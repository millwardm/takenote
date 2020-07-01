using System;
namespace Note.Domain.AggregatesModel.NotebookAggregate
{
    public class Entry
    {
        public int Id { get; private set; }

        private string _content;

        public Entry(String content)
        {
            _content = content;
        }


    }
}
