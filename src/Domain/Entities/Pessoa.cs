using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pessoa : Entity //gera um id gui geral aplicação ex:(1000))
    {
        //id Pessoa e um entnti guid PessoaId seria mesmo que esse pela logica
        // id =1000     

        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public bool Ativo { get; set; }
        public Endereco Endereco { get; set; } //ENDERECO ESTA VINDO DE OUTRA ENTIDADE, ENTÃO FAZ O SEU MAPEAMENTO DIRETO NO MAPING COM MODELAGEM, para gerar endereco precisa do IEnumerable

        /* EF Relations */
        // na classe da pessoa, preciso ter relação da listagem de 1 pessoa para miutos contratos
        // a entidade que recebe a listagem de  muitos precisa ser relacionada aqui em pessoa 
        public IEnumerable<Contrato> Contratos { get; set; } // MESMA FORMA, ESTA VINDO DE FORA, (UMA LISTAGEM), ENTÃO FAZ O SEU MAPEAMENTO DIRETO NO MAPING COM MODELAGEM

    }
}
