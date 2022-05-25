using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id); //gui id =1000

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");


            //diretamente da minha entidade pessoa eu gero a modelagn que repletira para o contrato
            //relação das colunas fk para entidade pessoa param um endereco

            // 1 : 1 => Fornecedor : Endereco | Um para Um |  gera FK Relacao
            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Pessoa);

            //relação das colunas fk para entidade pessoa param muitos contratos 

            // 1 : N => Fornecedor : Produtos | Um para Muitos |  gera FK Relacao
            builder.HasMany(f => f.Contratos) //tenho muitos contratos para...
                .WithOne(p => p.Pessoa)      // uma pessoa
                .HasForeignKey(p => p.PessoaId); 

            builder.ToTable("Pessoas");
        }
    }
}


//pessoa vai conversar com endereco e com o contrato atraves FK e finaizou.