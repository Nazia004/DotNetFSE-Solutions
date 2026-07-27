using KafkaDemoApi.Models;
using KafkaDemoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace KafkaDemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly KafkaProducerService _producer;

        public MessageController(KafkaProducerService producer)
        {
            _producer = producer;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(MessageModel model)
        {
            await _producer.ProduceAsync(model.Message);

            return Ok("Message sent successfully");
        }
    }
}