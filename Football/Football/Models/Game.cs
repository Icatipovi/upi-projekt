using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Game
    {
        [Key]
        public int Game_ID { get; set; }
        public Team? Home { get; set; }
        public Team? Guest { get; set; }
        public int ?HomeScore { get; set; }
        public int ?GuestScore { get; set; }
        public DateTime ?Date { get; set; }
    }
}
