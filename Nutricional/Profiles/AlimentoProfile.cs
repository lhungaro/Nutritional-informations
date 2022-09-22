using AutoMapper;
using Nutricional.Data.DTOs;
using Nutricional.Models;

namespace Nutricional.Profiles
{
    public class AlimentoProfile : Profile
    {

         public AlimentoProfile()
         {

            CreateMap<AlimentoDTO, Alimento>();
            CreateMap<Alimento, AlimentoDTO>();

         }
    }
}
