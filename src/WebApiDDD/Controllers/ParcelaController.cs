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
    public class ParcelaController : MainController //ControllerBase
    {
        private readonly IParcelaService _parcelaService;

        public ParcelaController(IParcelaService parcelaService) 
        {
            _parcelaService = parcelaService;
        }

        [AllowAnonymous]
        [HttpGet("Obter-Parcelas")]
        public async Task<IEnumerable<ParcelaDto>> ObterContratos()
        {
            return await _parcelaService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("ObterPorId-Parcelas")]
        public async Task<ActionResult<ParcelaDto>> ObterPorId(Guid id)
        {
            var parcelasPorId = await _parcelaService.ObterPorId(id);

            if (parcelasPorId == null) return NotFound();

            return parcelasPorId;
        }

        [AllowAnonymous]
        [HttpPost("Adicionar-Parcelas")]
        public async Task  Adicionar(ParcelaDto parcelaDto) 
        {
            await _parcelaService.Add(parcelaDto);
        }

        [AllowAnonymous]
        [HttpPut("Atualizar-Parcelas")]
        public async Task Atualizar(ParcelaDto parcelaDto) 
        {
            await _parcelaService.Update(parcelaDto);
        }

        [AllowAnonymous]
        [HttpDelete("Deletar-Parcelas")]
        public async Task Deletar(Guid id) 
        {
            await _parcelaService.Remove(id);
        }

    }
}

