using System.ComponentModel.DataAnnotations;

namespace Nutricional.Data.DTOs
{
    public class AlimentoDTO
    {
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string DescricaoNutricional { get; set; }
        [Required(ErrorMessage = "O campo Calorias é obrigatório")]
        public string Calorias { get; set; }
        public string GrupoAlimentar { get; set; }
        public double Umidade { get; set; }
        public double Energia { get; set; }
        public double Proteína { get; set; }
        public double Lipídeos { get; set; }
        public string Colesterol { get; set; }
        public double Carboidrato { get; set; }
        public double FibraAlimentar { get; set; }
        public double Cinzas { get; set; }
        public double Cálcio { get; set; }
        public double Magnésio { get; set; }
        public string Manganês { get; set; }
        public double Fósforo { get; set; }
        public double Ferro { get; set; }
        public double Sódio { get; set; }
        public double Potássio { get; set; }
        public string Cobre { get; set; }
        public double Zinco { get; set; }
        public string Retinol { get; set; }
        public string RE { get; set; }
        public string RAE { get; set; }
        public string Tiamina { get; set; }
        public string Riboflavina { get; set; }
        public string Piridoxina { get; set; }
        public string Niacina { get; set; }
        public string VitaminaC { get; set; }
    }
}
