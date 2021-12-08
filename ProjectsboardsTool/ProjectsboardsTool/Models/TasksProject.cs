using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectsboardsTool.Models
{
    public class TasksProject
    {
        [Key]
        public int ID { get; set; }
        public int Project { get; set; }
        public int Task { get; set; }
    }
}