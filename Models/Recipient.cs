namespace AdminToUserMailAPI.Models
{
    public class Recipient
    {
        public int Id { get; set; }
        public ICollection<Message>? Messages { get; set;}
    }
}
