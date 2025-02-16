﻿using AutoMapper;
using InmovestAPI.Domain.Models;
using InmovestAPI.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmovestAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Project, ProjectResource>();
            CreateMap<Manager, ManagerResource>();
            CreateMap<Campaign, CampaignResource>();
            CreateMap<Article, ArticleResource>();
        }
    }
}
