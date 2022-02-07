using AutoMapper;
using BankUserApi.Models;
using BankUserApi.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankUserApi.Application
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Bank, BankDto>().ReverseMap();
            CreateMap<Card, CardDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

        }
    }
}
