using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ContratoDto
    {
        public Guid Id { get; set; }
        public Guid PessoaId { get; set; }
        public string TipoContrato { get; set; }
        public string DescricaoContrato { get; set; }
        public DateTime DataCadastroContrato { get; set; }
        public bool Ativo { get; set; }
    }
}
