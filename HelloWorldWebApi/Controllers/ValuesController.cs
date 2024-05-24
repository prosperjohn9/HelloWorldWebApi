using HelloWorldWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<AppMessage> Get()
        {
            List<AppMessage> messages = new List<AppMessage>();
            messages.Add(new AppMessage() { Message = "HelloWorld!" });
            messages.Add(new AppMessage() { Message = "HelloGalaxy!" });
            messages.Add(new AppMessage() { Message = "HelloUniverse!" });
            return messages;
        }
    }
}
