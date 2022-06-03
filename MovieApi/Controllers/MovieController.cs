using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Data;
using MovieApi.Models;
using MovieApi.Models.InputModel;
using MovieApi.Models.ViewModel;

namespace MovieApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext _context;
        private readonly IMapper _mapper;

        public MovieController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IList<MovieViewModel>> GetMovies() =>
            _mapper.Map<List<MovieViewModel>>(_context.Movies.ToList());

        [HttpGet("{id:int}")]
        public ActionResult<MovieViewModel> GetMovie(int id)
        {
            var response = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            return response != null ? Ok(_mapper.Map<MovieViewModel>(response)) : NotFound();
        }

        [HttpPost]
        public ActionResult PostMovie([FromBody] MovieInputModel movie)
        {
            var value = _mapper.Map<Movie>(movie);
            _context.Movies.Add(value);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovie), new { Id = value.Id }, value);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Movie> PutMovie(int id, [FromBody] MovieInputModel movie)
        {
            var response = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (response == null) return NotFound();
            _mapper.Map(movie, response);
            _context.SaveChanges();
            return response;
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteMovie(int id)
        {
            var response = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (response == null) return NotFound();
            _context.Movies.Remove(response);
            _context.SaveChanges();
            return NoContent();
        }
    }
}