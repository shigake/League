using System;
using System.Text;

namespace League.Domain.Entities
{
    public class HistoricDetail
    {
        public Baron Baron { get; set; }
        public Challenges Challenges { get; set; }
        public Dragon Dragon { get; set; }
        public Info Info { get; set; }
        public Inhibitor Inhibitor { get; set; }
        public Metadata Metadata { get; set; }
        public MetadataBase MetadataBase { get; set; }
        public Objectives Objectives { get; set; }
        public Participant Participant { get; set; }
        public Perks Perks{ get; set; }
        public RiftHerald RiftHerald { get; set; }
        public Root Root { get; set; }
        public Selection Selection { get; set; }
        public StatPerks StatPerks { get; set; }
        public Style Style { get; set; }
        public Team Team { get; set; }
        public Tower Tower { get; set; }
    }
}
