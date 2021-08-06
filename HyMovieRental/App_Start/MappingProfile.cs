﻿using AutoMapper;
using HyMovieRental.Dtos;
using HyMovieRental.Models;

namespace HyMovieRental.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // The generic take 2 param, 1 is source type and other is target type
            Mapper.CreateMap<Customer, CustomerDto>();

            // .ForMember(...) purpose is to prevent from updating the existing customer Id to another Id
            // it's mission is simply ignore the Id property when you send PUT request to update the customer
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}