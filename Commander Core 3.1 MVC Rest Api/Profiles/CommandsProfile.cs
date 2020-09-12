using AutoMapper;
using Commander_Core_3._1_MVC_Rest_Api.Dtos;
using Commander_Core_3._1_MVC_Rest_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander_Core_3._1_MVC_Rest_Api.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}
