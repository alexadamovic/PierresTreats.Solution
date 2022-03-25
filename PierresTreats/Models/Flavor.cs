using System.Collections.Generic;

namespace PierresTreats.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.JoinEntities = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string Flav { get; set; }
        public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
    }
}