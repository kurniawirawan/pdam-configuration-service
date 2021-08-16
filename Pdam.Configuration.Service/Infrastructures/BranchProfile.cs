﻿using AutoMapper;

namespace Pdam.Configuration.Service.Infrastructures
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            CreateMap<DataContext.Branch, Features.Branch.Get.Response>();
            CreateMap<Features.Branch.Add.Request, DataContext.Branch>();
        }
    }
}