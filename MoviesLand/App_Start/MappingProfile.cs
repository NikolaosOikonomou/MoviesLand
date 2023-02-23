using AutoMapper;
using MoviesLand.Dtos;
using MoviesLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesLand.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}