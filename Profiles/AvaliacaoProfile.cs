using AutoMapper;
using AvaliacaoNetApiWeb.Dtos;
using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Profiles
{
    public class AvaliacaoProfile : Profile
    {
        public AvaliacaoProfile()
        {
            //Source -> Target
            CreateMap<People, PeopleReadDto>();

            CreateMap<Phone, PhoneReadDto>();

            CreateMap<Address, AddressReadDto>();
        }

    }
}
