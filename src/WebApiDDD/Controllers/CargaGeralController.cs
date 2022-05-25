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
    public class CargaGeralController : MainController
    {
        private readonly IPessoaService _pessoaService;

        public CargaGeralController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [AllowAnonymous]
        [HttpGet("ObterPessoasEndereco")]
        public async Task<ActionResult<PessoaEnderecoDto>> ObterPessoasEndereco(Guid id)
        {
            var pessoaEndereco = await _pessoaService.ObterPessoasEndereco(id);

            if (pessoaEndereco == null) return NotFound();

            return pessoaEndereco;
        }

        [AllowAnonymous]
        [HttpGet("ObterPessoaContratosEndereco")]
        public async Task<ActionResult<PessoaContratoEnderecoDto>> ObterPessoaContratosEndereco(Guid id)
        {
            var pessoaContratoEndereco = await _pessoaService.ObterPessoaContratosEndereco(id);

            if (pessoaContratoEndereco == null) return NotFound();

            return pessoaContratoEndereco;
        }


    }
}



