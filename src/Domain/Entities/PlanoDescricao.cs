using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PlanoDescricao: Entity
    {
        // id =1000   esse id entra com idea de parcelaid = CodParc
        public Guid ContratoId { get; set; }  // esse seria o fk do contrato q relaciona com contrato direto
        public Guid ParcelaId { get; set; }  // esse seria o fk do parcela q relaciona com parcela direto

        public string NomePlano { get; set; }
        public string DescricaoPlano { get; set; }
        public decimal DescontoPlano { get; set; }
        public DateTime DataCadastroParcela { get; set; }
        public bool Ativo { get; set; }  //pago não


        /* EF Relations */
        public Contrato Contratos { get; set; }
        public Parcela Parcelas { get; set; }


    }
}

               

//--id plano,  
//--contratoId(se precisar de relacinoamneto direto do contrato, sem detalhes da parcela sai direto do contrato para ClientePlano)), relação direta do contrato para plano sem parcelas
//--parcelaId     (relacinnar parcela se precisar de dados como valores, parcelas, etc..), 
//--NomePlano, 
//--DescricaoPlano,
//--DescontoPlano, 
//--datacadastro, 
//--ativo 