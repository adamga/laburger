using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace .NETCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        // In-memory storage for chat messages
        private static readonly List<string> messages = new List<string>();

        // POST api/chat/send
        [HttpPost("send")]
        public ActionResult Send([FromBody] string message)
        {
            messages.Add(message);
            return Ok();
        }

        // GET api/chat/receive
        [HttpGet("receive")]
        public ActionResult<IEnumerable<string>> Receive()
        {
            return Ok(messages);
        }
    }
}
