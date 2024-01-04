namespace BackEnd.Data
{
    public class Track : ConferenceDTO.Track
    {
        public virtual ICollection<Track> Tracks { get; set; } = null;
    }
}
