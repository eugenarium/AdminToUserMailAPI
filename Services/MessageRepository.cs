using AdminToUserMailAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminToUserMailAPI.Services
{
    public class MessageRepository : IMessageRepository
    {
        private readonly MesDb _dbContext;
        public MessageRepository(MesDb dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateMessage(MessagePost message)
        {
            var mes = new Message {
                Subject = message.Subject,
                Body = message.Body,
                Recipients = new List<Recipient>()
            };
            foreach (var item in message.Recipients)
            {
                var rcpt = await _dbContext.Recipients.FindAsync(item);
                rcpt ??= new Recipient();

                mes.Recipients.Add(rcpt);
            }
            _dbContext.Messages.Add(mes);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<MessageDto>> GetRecipientsMessages(int RecipientsId)
        {
            return await _dbContext.Messages
                .Where(m => m.Recipients.Any(r => r.Id == RecipientsId))
                .Select(m => new MessageDto(m))
                .ToListAsync();
        }
    }
}
