using System;
using System.Collections.Generic;

namespace TTRPG_Manager.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public bool IsInProcess { get; set; }

        public HashSet<string> TagList => _adventureBook.GetAllTags();

        public readonly AdventureBook<Adventure> _adventureBook;

        public Campaign(int id, DateTime creationDate, string name, bool isInProcess, AdventureBook<Adventure> adventureBook)
        {
            Id = id;
            CreationDate = creationDate;
            Name = name;
            IsInProcess = isInProcess;
            _adventureBook = adventureBook;
        }

        public Campaign(string name, bool isInProcess)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            IsInProcess = isInProcess;
            CreationDate = DateTime.Now;
            _adventureBook = new AdventureBook<Adventure>();
        }

        public Campaign()
        {
        }

        public IEnumerable<Adventure> GetAllAdventures() => _adventureBook.GetAll();

        public void AddAdventure(Adventure adventure)
        {
            _adventureBook.Add(adventure);
        }

        public HashSet<string> GetTags()
        {
            return TagList;
        }

        internal string TagListString()
        {
            string tags = "";
            if (TagList != null)
            {
                foreach (string tag in TagList) { tags += tag + " "; }
            }
            return tags.Trim();
        }
    }
}
