using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Position
    {
        [Key]
        public int Position_ID { get; set; }
        public string ?NameOfPosition { get; set; }

    }
}
