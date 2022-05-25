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
    public class ContratoMap : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {

            builder.HasKey(p => p.Id); //gui id =1000

            builder.Property(p => p.TipoContrato)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.DescricaoContrato)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            //diretamente da minha entidade contrato eu gero a modelagem que refletirar para o contrato plano
            //toda relação necessaria e gerado no map do contrato para a parcela e para plano, com quem contrato vai falar.
            //relação das colunas fk para entidade contrato param muitas parcelas e contrato para muitos planos

            // 1 : N gera relação de 1 contrato para muitas parcelas
            builder.HasMany(pa => pa.Parcelas)   // tenho muitas parcelas para..
                   .WithOne(co => co.Contratos) //  um contrato
                   .HasForeignKey(co => co.ContratoId);

            //1:N planosdescrição vai precisar para ligar contrato id origin com idcontrato fk plano
            builder.HasMany(cc => cc.PlanoDescricoes)
                   .WithOne(c => c.Contratos)
                   .HasForeignKey(pc => pc.ContratoId);

            builder.ToTable("Contratos");
        }
    }
}



// entendimento da regra, para aplicar no codigo

// pensa inverso, muitos contratos para uma pessoa
// pensa inverso, muitos parcelas para um contrato
/*
    // 1 : N => Fornecedor : Produtos | Um para Muitos

    builder.HasMany(f => f.Contratos) //tenho muitos contratos para...
        .WithOne(p => p.Pessoa)      // uma pessoa
        .HasForeignKey(p => p.PessoaId); 
*/