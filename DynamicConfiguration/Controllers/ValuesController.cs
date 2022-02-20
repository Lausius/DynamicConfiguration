using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DynamicConfiguration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Settings _settings;

        public ValuesController(IOptionsSnapshot<Settings> settings)
        {
            _settings = settings.Value;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public string Get()
        {
            return _settings.Message;
        }
    }
}
