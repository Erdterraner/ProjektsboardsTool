using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectsboardsTool.Data
{
    public class ProjectsboardsToolContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProjectsboardsToolContext() : base("name=ProjectsboardsToolContext")
        {
        }

        public System.Data.Entity.DbSet<ProjectsboardsTool.Models.Projekt> Projekts { get; set; }

        public System.Data.Entity.DbSet<ProjectsboardsTool.Models.Mitarbeiter> Mitarbeiters { get; set; }

        public System.Data.Entity.DbSet<ProjectsboardsTool.Models.Task> Tasks { get; set; }

        public System.Data.Entity.DbSet<ProjectsboardsTool.Models.TasksProject> TasksProjects { get; set; }

        public System.Data.Entity.DbSet<ProjectsboardsTool.Models.MitarbeiterProject> MitarbeiterProjects { get; set; }
    }
}
