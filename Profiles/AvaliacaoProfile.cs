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
            CreateMap<PeopleCreateDto, People>();

            CreateMap<Phone, PhoneReadDto>();
            CreateMap<PhoneCreateDto, Phone>();

            CreateMap<Address, AddressReadDto>();
            CreateMap<AddressCreateDto, Address>();
        }

    }
}
