using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class PessoaEnderecoDto
    {
        //mostrar na tela join da Pessoa+endereco
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int TipoPessoa { get; set; }
        public bool Ativo { get; set; }
        public EnderecoDto Endereco { get; set; }  //1:n


        //deixar por fora, por enquanto
       // public IEnumerable<ContratoDto> Contratos { get; set; } // contratos sõa muitos por isso da listagem ienumerable
    }
}
