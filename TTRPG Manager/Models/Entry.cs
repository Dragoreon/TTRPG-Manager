using System;

namespace TTRPG_Manager.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Titulo { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public Entry ParentEntry { get; set; }

        public Entry(int id, DateTime creationDate, string titulo, string content, string type, Entry parentEntry)
        {
            Id = id;
            CreationDate = creationDate;
            Titulo = titulo;
            Content = content;
            Type = type;
            ParentEntry = parentEntry;
        }

        public Entry()
        {
        }
    }
}
