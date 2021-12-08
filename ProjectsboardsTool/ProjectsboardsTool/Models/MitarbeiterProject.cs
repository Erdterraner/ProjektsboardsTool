using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectsboardsTool.Models
{
    public class MitarbeiterProject
    {
        [Key]
        public int ID { get; set; }
        public int Project { get; set; }
        public int Mitarbeiter { get; set; }
    }
}