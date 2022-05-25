using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDDD.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlanosController : MainController //ControllerBase
    {
        private readonly IPlanoService _planolaService;

        public PlanosController(IPlanoService planoService) 
        {
            _planolaService = planoService;
        }

        [AllowAnonymous]
        [HttpGet("Obter-Planos")]
        public async Task<IEnumerable<PlanoDto>> ObterContratos()
        {
            return await _planolaService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("ObterPorId-Planos")]
        public async Task<ActionResult<PlanoDto>> ObterPorId(Guid id)
        {
            var planosPorId = await _planolaService.ObterPorId(id);

            if (planosPorId == null) return NotFound();

            return planosPorId;
        }

        [AllowAnonymous]
        [HttpPost("Adicionar-Planos")]
        public async Task  Adicionar(PlanoDto planoDto) 
        {
            await _planolaService.Add(planoDto);
        }

        [AllowAnonymous]
        [HttpPut("Atualizar-Planos")]
        public async Task Atualizar(PlanoDto planoDto) 
        {
            await _planolaService.Update(planoDto);
        }

        [AllowAnonymous]
        [HttpDelete("Deletar-Planos")]
        public async Task Deletar(Guid id) 
        {
            await _planolaService.Remove(id);
        }

    }
}

