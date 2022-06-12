using AutoMapper;
using Pokemon_API.Data;
using Pokemon_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_API.Profiles
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile()
        {
            CreateMap<CreatePokemonDto, Pokemon>();

        }
    }
}
