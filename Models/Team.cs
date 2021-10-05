using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Week5.Models
{
    public class Team
    {
        [Key]
        public string TeamName {get; set;}
        public string City {get; set;}

        public IEnumerable<Player> Players {get; set;}//or List<Player>
    }
}