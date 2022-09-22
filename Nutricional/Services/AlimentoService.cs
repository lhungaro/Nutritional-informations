using Nutricional.Data.DTOs;
using Nutricional.Models;

namespace Nutricional.Services
{
    public class AlimentoService
    {
        public Alimento SerializaAlimentoDTO(AlimentoDTO alimentodto)
        {
            Alimento alimento = new Alimento 
            {
                Nome = alimentodto.Nome,
                DescricaoNutricional = alimentodto.DescricaoNutricional,
                GrupoAlimentar = alimentodto.GrupoAlimentar,
                Umidade = alimentodto.Umidade,
                Energia = alimentodto.Energia,
                Proteína = alimentodto.Proteína,
                Lipídeos = alimentodto.Lipídeos,
                Colesterol = alimentodto.Colesterol,
                Carboidrato = alimentodto.Carboidrato,
                FibraAlimentar = alimentodto.FibraAlimentar,
                Cinzas = alimentodto.Cinzas,
                Cálcio = alimentodto.Cálcio,
                Magnésio = alimentodto.Magnésio,
                Manganês = alimentodto.Manganês,
                Fósforo = alimentodto.Fósforo,
                Ferro = alimentodto.Ferro,
                Sódio = alimentodto.Sódio,
                Potássio = alimentodto.Potássio,
                Cobre = alimentodto.Cobre,
                Zinco = alimentodto.Zinco,
                Retinol = alimentodto.Retinol,
                RE = alimentodto.RE,
                RAE = alimentodto.RAE,
                Tiamina = alimentodto.Tiamina,
                Riboflavina = alimentodto.Riboflavina,
                Piridoxina = alimentodto.Piridoxina,
                Niacina = alimentodto.Niacina,
                VitaminaC = alimentodto.VitaminaC
            };

            return alimento;

        }
    }
}
