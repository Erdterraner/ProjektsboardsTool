using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectsboardsTool.Models
{
    public class Mitarbeiter
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public string Position { get; set; }
    }
}