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
            CreateMap<PeopleUpdateDto, People>();
            CreateMap<People, PeopleUpdateDto>();

            CreateMap<Phone, PhoneReadDto>();
            CreateMap<PhoneCreateDto, Phone>();
            CreateMap<PhoneUpdateDto, Phone>();
            CreateMap<Phone, PhoneUpdateDto>();

            CreateMap<Address, AddressReadDto>();
            CreateMap<AddressCreateDto, Address>();
            CreateMap<AddressUpdateDto, Address>();
            CreateMap<Address, AddressUpdateDto>();
        }

    }
}
