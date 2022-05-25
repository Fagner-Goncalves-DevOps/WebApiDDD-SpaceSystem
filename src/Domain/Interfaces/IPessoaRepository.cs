using Domain.Entities;
using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Task<Pessoa> ObterPessoaEndereco(Guid id);
        Task<Pessoa> ObterPessoaContratosEndereco(Guid id);
        

        // METODO ESPECIALIZADO PARA GERAR O POST COM RELAÇÃO DA PESSOA PARA O CONTRATO
        // se for necessario enviar os dados relacionados para  1 tabela geral
    }
}
