using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectsboardsTool.Models
{
    public class Projekt
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Projektleiter { get; set; }
        public int StandinProzent { get; set; }
        public int Budet { get; set; }
        public int MitarbeiterProjekt { get; set; }
        public int TasksProject { get; set; }

    }
}