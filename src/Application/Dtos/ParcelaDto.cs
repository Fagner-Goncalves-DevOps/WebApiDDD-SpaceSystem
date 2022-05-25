using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ParcelaDto
    {
        public Guid Id { get; set; }
        public Guid ContratoId { get; set; } 
        public string Plano { get; set; }
        public decimal ValorParcelas { get; set; }
        public DateTime DataCadastroParcela { get; set; }
        public bool Ativo { get; set; } 
    }
}
