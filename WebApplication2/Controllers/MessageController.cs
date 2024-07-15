using Microsoft.AspNetCore.Mvc;
using WebApplication2.BusinessLayer;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly MessageService _messageService;

        public MessageController(MessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var message = _messageService.GetMessage(id);
            if (message == null)
            {
                return NotFound();
            }

            return Ok(message.Text);
        }
    }
}
