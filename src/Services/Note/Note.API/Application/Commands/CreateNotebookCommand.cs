using System;
using System.Runtime.Serialization;
using MediatR;

namespace Note.API.Application.Commands
{
    [DataContract]
    public class CreateNotebookCommand : IRequest<bool>
    {
        [DataMember]
        public string Name { get; set; }

        public CreateNotebookCommand(String name)
        {
            Name = name;
        }

        public CreateNotebookCommand() { }
    }
}
