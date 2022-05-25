using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class PessoaContratoEnderecoDto
    {
        //mostrar na tela

        [Key]
        public Guid Id { get; set; }
        public string TipoContrato { get; set; }
        public string DescricaoContrato { get; set; }
        public DateTime DataCadastroContrato { get; set; }
        public bool Ativo { get; set; }
        public PessoaDto Pessoa { get; set; }
        public IEnumerable<ContratoDto> Contratos { get; set; }

        //public IEnumerable<Parcela> Parcelas { get; set; } //relacao para parcelas 1 para muitos
    }
}
