namespace TennisSource.Models
{
    public class @TennisTournament
    {
        public int TennisTournamentId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location {  get; set; } = string.Empty;
        public string Organizer { get; set; } = string.Empty;
        public DateTime Date { get; set; }



        // Foreign Key

        public int TypeId { get; set; }

        //nav

        public TournamentType? TournamentType { get; set; }


    }
}
