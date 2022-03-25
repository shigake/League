using System.Collections.Generic;

namespace League.Domain.Entities
{
    public class MetadataBase
    {
        public string dataVersion { get; set; }
        public string matchId { get; set; }
        public List<string> participants { get; set; }
    }
}