namespace League_Info_app.Models
{
	public class ChampionMasteryDto
	{
		public long championPointsUntilNextLevel { get; set; }
		public bool chestGranted { get; set; }
		public long championId { get; set; }
        public long lastPlayTime { get; set; }
        public int championLevel { get; set; }
        public string summonerId { get; set; }
        public int championPoints { get; set; }
        public long championPointsSinceLastLevel { get; set; }
        public int tokensEarned { get; set; }
    }
}
