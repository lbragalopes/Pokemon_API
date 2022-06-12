using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokemon_API.Data;
using Pokemon_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class PokemonController : ControllerBase
    {
        private PokemonContext _context;
        private IMapper _mapper;

        public PokemonController(PokemonContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
      
        [HttpPost]
        public IActionResult CadastraPokemon([FromBody] CreatePokemonDto pokemonDto)
        {
            Pokemon pokemon = _mapper.Map<Pokemon>(pokemonDto);
           
            _context.Pokemons.Add(pokemon);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ConsultaPokemonPorCodigo), new { Codigo = pokemon.Codigo }, pokemon);
        }


        [HttpGet]
        public IEnumerable<Pokemon> ConsultaPokemon()
        {
            return _context.Pokemons;
        }

        [HttpGet("{codigo}")]
        public IActionResult ConsultaPokemonPorCodigo(int codigo)
        {
            Pokemon pokemon = _context.Pokemons.FirstOrDefault(pokemon => pokemon.Codigo == codigo);
            if(pokemon != null)
            {
                return Ok(pokemon);
            }
            return NotFound();
        }

        [HttpDelete("{codigo}")]
        public IActionResult DeletaPokemon(int codigo)
        {
            Pokemon pokemon = _context.Pokemons.FirstOrDefault(pokemon => pokemon.Codigo == codigo);
            if (pokemon == null)
            {
                return NotFound();
            }
            _context.Remove(pokemon);
            _context.SaveChanges();
            return NoContent();

        }
    }
}
