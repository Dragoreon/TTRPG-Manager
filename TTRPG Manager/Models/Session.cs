using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Models
{
    public class Session
    {
        public Entry EntrySession { get; set; }
        public int NumSession { get; set; }

        public Session(Entry entrySession, int numSession)
        {
            EntrySession = entrySession;
            NumSession = numSession;
        }

        public Session()
        {
        }
    }
}
