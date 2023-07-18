using System.Text.Json.Serialization;

namespace AdminToUserMailAPI.Models
{
    public class MessagePost
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<int> Recipients { get; set; }

    }
}
