using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPlanoService : IDisposable
    {

        Task<IEnumerable<PlanoDto>> GetAll();
        Task<PlanoDto> ObterPorId(Guid id);
        Task Add(PlanoDto planoDto);
        Task Update(PlanoDto planoDto);
        Task Remove(Guid id);

        //Especializados
        //Task<PessoaEnderecoDto> ObterPessoasEndereco(Guid id);
        //Task<PessoaContratoEnderecoDto> ObterPessoaContratosEndereco(Guid id);


    }
}
