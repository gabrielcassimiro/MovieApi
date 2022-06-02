using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Data;
using MovieApi.Models;
using MovieApi.Models.InputModel;

namespace MovieApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectorController : ControllerBase
    {
        private readonly MovieContext _context;
        private readonly IMapper _mapper;

        public DirectorController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<IList<Director>> GetDirectors() => _context.Directors.ToList();

        [HttpGet("{id:int}")]
        public ActionResult<Director> GetDirector(int id)
        {
            var response = _context.Directors.FirstOrDefault(director => director.Id == id);
            return response != null ? Ok(response) : NotFound();
        }

        [HttpPost]
        public ActionResult PostDirector([FromBody] DirectorInputModel director)
        {
            var value = _mapper.Map<Director>(director);
            _context.Directors.Add(value);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetDirector), new {Id = value.Id}, value);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Director> PutDirector(int id, [FromBody] DirectorInputModel director)
        {
            var response = _context.Directors.FirstOrDefault(d => d.Id == id);
            if (response == null) return NotFound();
            _mapper.Map(director, response);
            _context.SaveChanges();
            return response;
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteDirector(int id)
        {
            var response = _context.Directors.FirstOrDefault(director => director.Id == id);
            if (response == null) return NotFound();
            _context.Directors.Remove(response);
            _context.SaveChanges();
            return NoContent();
        }
    }
}