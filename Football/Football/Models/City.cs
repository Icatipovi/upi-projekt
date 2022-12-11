using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class City
    {
        [Key]
        public int City_ID { get; set; }
        public string? NameOfCity { get; set; }
    }
}
