using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Services.DTOs.Admin.Countries;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;


     public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {

            _countryRepository = countryRepository;
            _mapper = mapper;
            
        }

        public async Task CreateAsync(CountryCreateDto model)
        {
            
            if (model == null)
            {
                throw new ArgumentNullException(); 
            }
                await _countryRepository.CreateAsync(_mapper.Map<Country>(model));
          
        }

        public async  Task<IEnumerable<CountryDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<CountryDto>>(await _countryRepository.GetAllAsync());
        }
    }
}
