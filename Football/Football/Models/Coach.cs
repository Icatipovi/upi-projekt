using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Coach
    {
        [Key]
        public int Coach_ID { get; set; }
        public string? CoachName { get; set; }
        public string ?CoachLastName { get; set; }

    }
}
