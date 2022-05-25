using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class PessoaDto
    {
        [Key]
        public Guid Id { get; set; } //trazer o id para conseguir fazer validações
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int TipoPessoa { get; set; }
        public bool Ativo { get; set; }
    }
}

