using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Models
{
     public class RuleManual
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public RuleSystem RuleSystem { get; set; }
        public DateTime CreationDate { get; set; }
        public string Type { get; set; }

        // todo: comprobar Crud archivo
        public FileAccess Archivo { get; set; }

        // todo: establecer una forma óptima de hacer un crud con los hipervínculos de pdf.
        /// <summary>
        /// Diccionario para guardar los hipervínculos en un archivo PDF
        /// Dentro de un diccionario puede haber un hipervínculo u otros diccionarios con contenido.
        /// </summary>
        public Dictionary<string, object> Bookmarks { get; set; }

        public RuleManual(int id, string title, RuleSystem ruleSystem, DateTime creationDate, string type, FileAccess archivo, Dictionary<string, object> bookmarks)
        {
            Id = id;
            Title = title;
            RuleSystem = ruleSystem;
            CreationDate = creationDate;
            Type = type;
            Archivo = archivo;
            Bookmarks = bookmarks;
        }

        public RuleManual(int id, string title)
        {
            Id = id;
            Title = title;
            CreationDate = DateTime.Now;
        }

        public RuleManual()
        {
        }
    }
}
