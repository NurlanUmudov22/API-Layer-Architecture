using AutoMapper;
using Domain.Entities;
using Services.DTOs.Admin.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CountryCreateDto, Country>();

            CreateMap<Country, CountryDto>();


        }

    }
}
