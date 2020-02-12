using AutoMapper;
using ScientificResearch.Core.Business.Models.Levels;
using ScientificResearch.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScientificResearch.Core.Business.Models
{
    public class Automapping : Profile
    {
        public Automapping()
        {
            CreateMap<LevelManageModel, Level>();
        }
    }
}
