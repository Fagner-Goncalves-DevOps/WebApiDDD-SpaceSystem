using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contrato : Entity
    {
        public Guid PessoaId { get; set; }  //id dele e um entity tambem gui  // FK id =1000    

        public string TipoContrato { get; set; }
        public string DescricaoContrato { get; set; }
        public DateTime DataCadastroContrato { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        // relação entre pessoa e contrato 
        public Pessoa Pessoa { get; set; } //serve somente para relação nao entra no processo databela entre contrato e pessoa, ou pessoa e contrato
        public IEnumerable<Parcela> Parcelas { get; set; } //relacao para parcelas 1 para muitos, deve tr relacao com a parcela, para migration
        public IEnumerable<PlanoDescricao> PlanoDescricoes { get; set; } //relacao para parcelas 1 para muitos, deve tr relacao com a parcela, para migration
    }
}
