using System;
using System.Threading.Tasks;
using FilterApiImplement.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterApiImplement.Controllers
{
    [ApiController]
    [Route("/moive")]
    public class MovieController: ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IActionResult Post([FromBody] Movie movie)
        {
            return CreatedAtRoute("MovieById", new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        async public Task<Guid> Put(Guid id, [FromBody]Movie movie)
        {
            if (id.GetType() != typeof(Guid))
            {
                return new Guid();
            }
            return id;
        }
    }
}