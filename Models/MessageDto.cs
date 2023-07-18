namespace AdminToUserMailAPI.Models
{
    public class MessageDto
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public MessageDto(Message message)
        {
            Subject = message.Subject;
            Body = message.Body;
        }
    }
}
