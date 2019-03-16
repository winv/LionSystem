using AutoMapper;
using LionServer.Application.ViewModels;
using LionServer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LionServer.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}
