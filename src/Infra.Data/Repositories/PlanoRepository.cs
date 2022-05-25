using Domain.Entities;
using Domain.Interfaces;
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
    public class PlanoRepository : Repository<PlanoDescricao> , IPlanoRepository
    {
        public PlanoRepository(SqlDbContext context ) : base (context) {}

    }
}

