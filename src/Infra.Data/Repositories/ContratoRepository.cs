using Domain.Entities;
using Domain.Interfaces.Generics;
using Infra.Data.Context;
using Infra.Data.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class ContratoRepository : Repository<Contrato> , IContratoRepository
    {
        public ContratoRepository (SqlDbContext context ) : base (context) {}

    }
}
