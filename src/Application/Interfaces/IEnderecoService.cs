using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEnderecoService : IDisposable
    {
        Task<IEnumerable<EnderecoDto>> GetAll();
        Task<EnderecoDto> ObterPorId(Guid id);
        Task Add(EnderecoDto enderecoDto);
        Task Update(EnderecoDto enderecoDto);
        Task Remove(Guid id);


        //Task<ContratoDto> GetById(Guid id);
        //Task<PessoaDto> Add(PessoaDto pessoaDto);
        //Task<PessoaDto> Update(PessoaDto pessoaDto);
        //Task<PessoaDto> Remove(Guid id);
    }
}
