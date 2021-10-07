using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tasker.Models
{
    [Table("Task")]
    public class Task
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        [Display(Name = "Execution Date")]
        public DateTime ExecutionDate { get; set; }

        [Display(Name = "Finished ?")]
        public Boolean Finished { get; set; }

        // packages required
        // 1. Microsoft.EntityFrameworkCore
        // 2. Microsoft.EntityFrameworkCore.SqlServer - needed for SQL server iteraction
        // 3. Microsoft.EntityFrameworkCore.Tools
        // 4/ Microsoft.EntityFrameworkCore.SqlServer.Design - needed for Controller design view scafolding....

        // Connection string is saved at appsettings.json
        // to read the Default connection string, using CTOR and Iconfiguration Dependency injection...

    }
}
