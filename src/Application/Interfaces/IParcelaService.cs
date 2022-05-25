using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IParcelaService : IDisposable
    {
 
        Task<IEnumerable<ParcelaDto>> GetAll();
        Task<ParcelaDto> ObterPorId(Guid id);
        Task Add(ParcelaDto parcelaDto);
        Task Update(ParcelaDto parcelaDto);
        Task Remove(Guid id);


        //Especializados
        //Task<PessoaEnderecoDto> ObterPessoasEndereco(Guid id);
        //Task<PessoaContratoEnderecoDto> ObterPessoaContratosEndereco(Guid id);


    }
}
