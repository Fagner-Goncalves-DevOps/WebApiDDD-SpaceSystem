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
    public class ContratoController : MainController //ControllerBase
    {
        private readonly IContratoService _contratoService;

        public ContratoController(IContratoService contratoService) 
        {
            _contratoService = contratoService;
        }

        [AllowAnonymous]
        [HttpGet("Obter-Contratos")]
        public async Task<IEnumerable<ContratoDto>> ObterContratos()
        {
            return await _contratoService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("ObterPorId-Contratos")]
        public async Task<ActionResult<ContratoDto>> ObterPorId(Guid id)
        {
            var contratosPorId = await _contratoService.ObterPorId(id);

            if (contratosPorId == null) return NotFound();

            return contratosPorId;
        }

        [AllowAnonymous]
        [HttpPost("Adicionar-Contratos")]
        public async Task  Adicionar(ContratoDto contratoDto) 
        {
            await _contratoService.Add(contratoDto);
        }

        [AllowAnonymous]
        [HttpPut("Atualizar-Contratos")]
        public async Task Atualizar(ContratoDto contratoDto) 
        {
            await _contratoService.Update(contratoDto);
        }

        [AllowAnonymous]
        [HttpDelete("Deletar-Contratos")]
        public async Task Deletar(Guid id) 
        {
            await _contratoService.Remove(id);
        }

    }
}

