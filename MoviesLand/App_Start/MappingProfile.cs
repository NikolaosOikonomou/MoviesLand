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
            Mapper.CreateMap<Customer, CustomerDto>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}