using System.Collections.Generic;

namespace League.Domain.Entities
{
    public class Team
    {
        public List<object> bans { get; set; }
        public Objectives objectives { get; set; }
        public int teamId { get; set; }
        public bool win { get; set; }
    }


}
