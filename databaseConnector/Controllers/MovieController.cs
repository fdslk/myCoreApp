using Microsoft.AspNetCore.Mvc;
using databaseConnector.dbconnector;
using databaseConnector.model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace databaseConnector.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class MoviveController : ControllerBase{
        private MoiveConnector _moiveConnector;

        private readonly ILogger<Moive> _logger;

        public MoviveController(MoiveConnector moiveConnector,
        ILogger<Moive>logger){
            _moiveConnector = moiveConnector;
            _logger = logger;
        }

        [HttpGet]
        public IList<Moive> GetList(){
            return (this._moiveConnector.moives.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Moive moive)
        {
            this._moiveConnector.Add(moive);
            var count=_moiveConnector.SaveChanges();
            _logger.LogDebug($"save {count} entitys successfully.");
            return Ok(count);
        }
    }
}