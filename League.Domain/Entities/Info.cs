using System.Collections.Generic;

namespace League.Domain.Entities
{
    public class Info
    {
        //public Challenges Challenges { get; set; }
        //public Participant participants { get; set; }
        //public Perks Perks { get; set; }
        //public Root Root { get; set; }
        //public Selection Selection { get; set; }
        //public StatPerks StatPerks { get; set; }
        //public Style Style { get; set; }
        //public Team Team { get; set; }
        public long gameCreation { get; set; }
        public int gameDuration { get; set; }
        public long gameEndTimestamp { get; set; }
        public long gameId { get; set; }
        public string gameMode { get; set; }
        public string gameName { get; set; }
        public long gameStartTimestamp { get; set; }
        public string gameType { get; set; }
        public string gameVersion { get; set; }
        public int mapId { get; set; }
        //public List<Participant> participants { get; set; }
        public string platformId { get; set; }
        public int queueId { get; set; }
        public List<Team> teams { get; set; }
        public string tournamentCode { get; set; }
    }


}
