using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitrineLuxury.Entities.Concrete;
using VitrineLuxury.Entities.DTO;

namespace VitrineLuxuryWebAPI.Mapping
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            CreateMap<Project, ProjectDto>();
            CreateMap<ProjectDto, Project>();
            CreateMap<Project, ProjectWithImageUrlDto>();
            CreateMap<ProjectWithImageUrlDto, Project>();
        }
    }
}
