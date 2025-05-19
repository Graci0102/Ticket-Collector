using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Entites.DTO;
using Problems.Entites;

namespace Problems.Logic
{
    public class DTOProvider
    {
        public Mapper Mapper { get; }
        public DTOProvider()
        {
            Mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProblemPostDTO, Problem>();
                cfg.CreateMap<Problem, ProblemGetDTO>();
            }));
        }
    }
}
