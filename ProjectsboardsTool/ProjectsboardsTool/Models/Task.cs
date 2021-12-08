using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectsboardsTool.Models
{
    public class Task
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ZeitAufwand { get; set; }
        public int Bearbeiter { get; set; }
    }
}