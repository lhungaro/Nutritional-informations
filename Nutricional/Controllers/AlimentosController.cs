using Nutricional.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Nutricional.Data;
using Nutricional.Data.DTOs;
using AutoMapper;

namespace Alimentos.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AlimentosController : ControllerBase
    {

        private AlimentoContext _context;
        private IMapper _mapper;
        //private AlimentoService _alimentoService;

        //public AlimentosController(AlimentoService alimentoService)
        //{
        //    _alimentoService = alimentoService;
        //}

        public AlimentosController(AlimentoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarAlimento([FromBody] AlimentoDTO alimentoDto) 
        {
            Alimento alimento = _mapper.Map<Alimento>(alimentoDto);
            //alimento = SerializaAlimentoDTO(alimentoDto);
            
            _context.Alimentos.Add(alimento);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAlimentoById), new { Id = alimento.Id }, alimento);
        }

        [HttpGet]
        public IEnumerable<Alimento> GetAlimento()
        {
            return _context.Alimentos;

        }
        [HttpGet("{id}")]
        public IActionResult GetAlimentoById(int id)
        {
            Alimento _alimento = _context.Alimentos.FirstOrDefault(alimento => alimento.Id == id);

            AlimentoDTO alimentodto = _mapper.Map<AlimentoDTO>(_alimento);

            return alimentodto != null ? Ok(alimentodto) : NotFound();

        }

        [HttpPut("{id}")]
        public IActionResult PutAlimentoById(int id, [FromBody] AlimentoDTO alimentoNovoDto)
        {
            Alimento alimento = _context.Alimentos.FirstOrDefault(alimento => alimento.Id == id);
            if( alimento == null)
                return NotFound();

            _mapper.Map(alimentoNovoDto, alimento);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAlimento(int id)
        {
            Alimento alimento = _context.Alimentos.FirstOrDefault(alimento => alimento.Id == id);

            if (alimento == null)
                return NotFound();

            _context.Remove(alimento);
            _context.SaveChanges();
            return NoContent();
        }

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
