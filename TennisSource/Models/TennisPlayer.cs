namespace TennisSource.Models
{
    public class TennisPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        public List<Event>? EventsParticipatedIn { get; set; }
    }
}
