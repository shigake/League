using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace League.Domain.Entities
{
    public class Summoner
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("accountId")]
        public string AccountID { get; set; }
        [JsonProperty("puuid")]
        public string PuuID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("profileIconId")]
        public long ProfileIconID { get; set; }
        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }
        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }
    }
}
