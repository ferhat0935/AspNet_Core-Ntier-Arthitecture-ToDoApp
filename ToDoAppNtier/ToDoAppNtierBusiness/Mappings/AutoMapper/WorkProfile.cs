using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNtierDtos.WorkDtos;
using ToDoAppNtierEntities.Domains;

namespace ToDoAppNtierBusiness.Mappings.AutoMapper
{
    public class WorkProfile:Profile
    {
        public WorkProfile()
        {
            CreateMap<Work, WorkListDto>().ReverseMap();  //Work entitisini Worklistdto ya çevir dedik.Revever tam tersi de olabilir demek
            CreateMap<Work, WorkCreateDto>().ReverseMap();
            CreateMap<Work, WorkUpdateDto>().ReverseMap();
            CreateMap<WorkListDto,WorkUpdateDto>().ReverseMap();    
        }
    }
}
