using AdminToUserMailAPI.Models;
using AdminToUserMailAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdminToUserMailAPI.Controllers
{
    [ApiController]
    [Route("api/v1/messages")]
    public class MessageController : Controller
    {
        private readonly IMessageRepository _db;
        public MessageController(IMessageRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<MessagePost>>> Get(int rcpt)
        {
            var list = await _db.GetRecipientsMessages(rcpt);
            return list.Count != 0 ? Ok(list) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> Post(MessagePost message)
        {
            await _db.CreateMessage(message);
            return Ok();
        }
    }
}
