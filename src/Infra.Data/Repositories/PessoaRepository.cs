using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    { 
        public PessoaRepository(SqlDbContext context) : base(context) { }


        //gerar metodos aqui especializados com buscas cruzadas, querys trazendo carga 2 tabelas, usando INCLUDE
        public async Task<Pessoa> ObterPessoaEndereco(Guid id)
        {
            return await Db.Pessoas.AsNoTracking()
                                .Include(p => p.Endereco)
                                .FirstOrDefaultAsync(P => P.Id == id); // se nao for isso, retorn uma lista, precisamos do 1°
        }

        public async Task<Pessoa> ObterPessoaContratosEndereco(Guid id)
        {
            return await Db.Pessoas.AsNoTracking()
                                 .Include(p => p.Contratos)
                                 .Include(p => p.Endereco)
                                 .FirstOrDefaultAsync(P => P.Id == id);
        }
    }
}
