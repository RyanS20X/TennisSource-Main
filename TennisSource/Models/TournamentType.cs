namespace TennisSource.Models
{
    public class TournamentType
    {
        public int TournamentTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public List<TennisTournament>? Tournaments { get; set; }
    }
}
