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
    public class EnderecoController : MainController //ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController (IEnderecoService enderecoService) 
        {
            _enderecoService = enderecoService;
        }

        [AllowAnonymous]
        [HttpGet("Obter-Endereços")]
        public async Task<IEnumerable<EnderecoDto>> ObterEndereco() 
        {
            return await _enderecoService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("ObterPorId-Endereços")]
        public async Task<ActionResult<EnderecoDto>> ObterPorId(Guid id) 
        {
            var enderecoPorId = await _enderecoService.ObterPorId(id);

            if (enderecoPorId == null) return CustomResponse();

            return CustomResponse(enderecoPorId);
        }

        [AllowAnonymous]
        [HttpPost("Adicionar-Endereços")]
        public async Task<ActionResult<EnderecoDto>> Adicionar(EnderecoDto enderecoDto)
        {
            if (!ModelState.IsValid) return CustomResponse();

            await _enderecoService.Add(enderecoDto);

            return CustomResponse(enderecoDto);

        }

        [AllowAnonymous]
        [HttpPut("Atualizar-Endereços")]
        public async Task<ActionResult<EnderecoDto>> Atualizar(EnderecoDto enderecoDto) 
        {
            if (!ModelState.IsValid) return  CustomResponse();

             await _enderecoService.Update(enderecoDto);

            return CustomResponse(enderecoDto);

        }

        [AllowAnonymous]
        [HttpDelete("Deletar-Endereços")]
        public async Task<IActionResult> Deletar(Guid id) 
        {
            await _enderecoService.Remove(id);
            return CustomResponse();
        }

    }
}
