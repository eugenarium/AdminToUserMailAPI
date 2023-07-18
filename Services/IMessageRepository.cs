using AdminToUserMailAPI.Models;

namespace AdminToUserMailAPI.Services
{
    public interface IMessageRepository
    {
        Task<bool> CreateMessage(MessagePost message);
        Task<List<MessageDto>> GetRecipientsMessages(int RecipientsId);
    }
}
