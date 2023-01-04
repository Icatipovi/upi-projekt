using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Player
    {
        [Key]
        public int Player_ID { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int PlayerNumber { get; set; }
        public double AverageMark { get; set; }
        public Team? Team { get; set; }
        public Position? Position { get; set; }

    }
}
