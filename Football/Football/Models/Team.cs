using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Team
    {
        [Key]
        public int Team_ID { get; set; }
        public string NameOfTeam { get; set; }
        public City City { get; set; }
        public Coach Coach { get; set; }
        public Scale Scale { get; set; }
    }
}
