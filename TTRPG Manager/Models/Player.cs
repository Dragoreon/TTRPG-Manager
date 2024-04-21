using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Description { get; set; }
        public string Motivation { get; set; }
        public string Contact {  get; set; }
        public List<string> TagList {  get; set; }

        public Player(int id, string name, string nickName, string description, string motivation, string contact, List<string> tagList)
        {
            Id = id;
            Name = name;
            NickName = nickName;
            Description = description;
            Motivation = motivation;
            Contact = contact;
            TagList = tagList;
        }

        public Player()
        {
        }
    }

}
