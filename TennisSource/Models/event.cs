namespace TennisSource.Models
{
    public class @Event
    {
        public int EventId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location {  get; set; } = string.Empty;
        public DateTime Date { get; set; }

        // Foreign Key

        public int TennisPlayerId { get; set; }

        //nav

        public List<TennisPlayer>? Players { get; set; }
    }
}
