using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PropertyAPI.App.DTO.Property;

namespace PropertyAPI.Controllers
{
    [
        ApiController,
        Route("api/[controller]")
    ]
    public class PropertyController : ControllerBase
    {
        private readonly ILogger<PropertyController> logger;



        public PropertyController(ILogger<PropertyController> Logger)
            : base()
        {
            this.logger = Logger;
        }



        [
            HttpPost
        ]
        public ActionResult CreateProperty([FromBody] PropertyDTO Property)
        {
            return this.Created();
        }
    }
}