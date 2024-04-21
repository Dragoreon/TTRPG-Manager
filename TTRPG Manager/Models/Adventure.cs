using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TTRPG_Manager.Models
{
    public class Adventure
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public bool IsInProcess { get; set; }
        public HashSet<string> TagList { get; set; }
        public List<RuleManual> RuleManualList { get; set; }
        public List<Entry> EntryList { get; set; }

        public Adventure(int id, DateTime creationDate, string name, Image image, bool isInProcess, HashSet<string> tagList, List<RuleManual> ruleManualList, List<Entry> entryList)
        {
            Id = id;
            CreationDate = creationDate;
            Name = name;
            Image = image;
            IsInProcess = isInProcess;
            TagList = tagList;
            RuleManualList = ruleManualList;
            EntryList = entryList;
        }

        public Adventure()
        {
        }

        internal string TagListString()
        {
            string tags = string.Empty;
            if (TagList != null)
            {
                foreach (string tag in TagList) { tags += tag + " "; }
            }
            return tags.Trim();
        }
    }
}
