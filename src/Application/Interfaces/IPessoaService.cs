using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPessoaService : IDisposable
    {
 
        Task<IEnumerable<PessoaDto>> GetAll();
        Task<PessoaDto> ObterPorId(Guid id);
        Task Add(PessoaDto pessoaDto);
        Task Update(PessoaDto pessoaDto);
        Task Remove(Guid id);


        //Especializados
        Task<PessoaEnderecoDto> ObterPessoasEndereco(Guid id);
        Task<PessoaContratoEnderecoDto> ObterPessoaContratosEndereco(Guid id);


    }
}
