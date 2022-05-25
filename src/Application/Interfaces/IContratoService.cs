using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{

    public interface IContratoService : IDisposable
    {
        Task<IEnumerable<ContratoDto>> GetAll();  
        Task<ContratoDto> ObterPorId(Guid id);
        Task Add(ContratoDto contratoDto);
        Task Update(ContratoDto contratoDto);
        Task Remove(Guid id);

        //Task<ContratoDto> GetById(Guid id);
        //Task<PessoaDto> Add(PessoaDto pessoaDto);
        //Task<PessoaDto> Update(PessoaDto pessoaDto);
        //Task<PessoaDto> Remove(Guid id);
    }
}
