using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string No { get; set; }
        public int Limit { get;set; }
        public DateTime StartDate { get; set; }

    }
}
