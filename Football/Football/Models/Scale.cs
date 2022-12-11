using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Scale
    {
        [Key]
        public int Scale_ID { get; set; }
        public int Points { get; set; }
        public int ScalePosition { get; set; }

    }
}
