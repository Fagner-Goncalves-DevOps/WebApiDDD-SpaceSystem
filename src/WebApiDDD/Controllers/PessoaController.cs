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
    public class PessoaController : MainController //ControllerBase //: ApiController
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService) 
        {
            _pessoaService = pessoaService;
        }
       

        [AllowAnonymous]
        [HttpGet("Obter-Pessoas")]
        public async Task<IEnumerable<PessoaDto>> ObterPessoas() 
        {
            return await _pessoaService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("ObterPorId-Pessoas")]
        public async Task<ActionResult<PessoaDto>> ObterPorId(Guid id) //quando usa condicional badresquet precisa ser action
        {
            var pessoasporid = await _pessoaService.ObterPorId(id);

            if (pessoasporid == null) return CustomResponse();

            return CustomResponse(pessoasporid);
        }

        [AllowAnonymous]
        [HttpPost("Adicionar-Pessoas")] 
        public async Task<ActionResult<PessoaDto>> Adicionar(PessoaDto pessoaDto) 
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _pessoaService.Add(pessoaDto);

            return CustomResponse(pessoaDto);
        }

        [AllowAnonymous]
        [HttpPut("Atualizar-Pessoas")]
        public async Task<ActionResult<PessoaDto>> Atualizar(PessoaDto pessoaDto) 
        {
            //validação especifica por Id se precisar

            //if (id != fornecedorViewModel.Id)
            //{
            //    NotificarErro("O id informado não é o mesmo que foi passado na query");
            //    return CustomResponse(fornecedorViewModel);
            //}

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _pessoaService.Update(pessoaDto);

            return CustomResponse(pessoaDto);
        }

        [AllowAnonymous]
        [HttpDelete("Deletar-Pessoas")]
        public async Task<IActionResult> Deletar(Guid id) 
        {
            await _pessoaService.Remove(id);
            return CustomResponse();
        }
    }
}


