using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Parcela : Entity
    {
        // id =1000   esse id entra com idea de parcelaid = CodParc
        public Guid ContratoId { get; set; }  // esse seria o fk do contrato q relaciona com parcela

        public string Plano { get; set; }
        public decimal ValorParcelas { get; set; }
        public DateTime DataCadastroParcela { get; set; }
        public bool Ativo { get; set; }  //pago não
        //1:1 passa doireto a classe
        public PlanoDescricao PlanoDescricoes { get; set; }

        /* EF Relations */
        public Contrato Contratos { get; set; }


        //1:1 nao precisa
        //public IEnumerable<PlanoDescricao> PlanoDescricoes { get; set; } //relacao para parcelas 1 para muitos, deve tr relacao com a parcela, para migration

    }
}
