using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class PlanoDto
    {
        public Guid Id { get; set; }
        public Guid ContratoId { get; set; } 
        public Guid ParcelaId { get; set; }  
        public string NomePlano { get; set; }
        public string DescricaoPlano { get; set; }
        public decimal DescontoPlano { get; set; }
        public DateTime DataCadastroParcela { get; set; }
        public bool Ativo { get; set; } 
    }
}
