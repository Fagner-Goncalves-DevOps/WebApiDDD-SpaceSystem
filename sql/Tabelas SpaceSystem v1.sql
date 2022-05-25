USE [ModeloTelecom]


select 
	p.id as 'idpessoa',
	--e.id as 'idendereco',
	--c.id as 'idcontrato',
	--pa.Id as 'idparcela',
	--pl.Id as 'idplano',
	p.nome,
	p.Documento,
	p.tipopessoa,
	c.TipoContrato,
	c.DescricaoContrato,
	c.ativo,
	e.Cidade,
	e.Estado,
	pa.Plano,
	pa.ValorParcelas,
	pl.NomePlano,
	pl.DescricaoPlano
from
	[Pessoas] p with(nolock) 
	left join [Contratos] c with(nolock) on c.PessoaId = p.Id
	left join [Enderecos] e with(nolock) on e.PessoaId =  p.Id
		 join [Parcelas]  pa with(nolock) on pa.ContratoId = c.Id
		 join [PlanoDescricoes] pl with(nolock) on pl.ParcelaId = pa.Id
											and pl.ContratoId = pa.ContratoId
where
	pa.Plano = '12x'




--v1 se precisar sair do contrato direto para planos, tem relação
select 
	distinct
	c.TipoContrato,
	pl.DescricaoPlano
from
	[Contratos] c with(nolock)
	join [PlanoDescricoes] pl with(nolock) on pl.ContratoId = c.Id

--v2
select
	distinct
	c.TipoContrato,
	pl.NomePlano,
	pl.DescricaoPlano,
	pa.Plano,
	pa.ValorParcelas
from
	[Contratos] c with(nolock)
	join [Parcelas]  pa with(nolock) on pa.ContratoId = c.Id
    join [PlanoDescricoes] pl with(nolock) on pl.ContratoId = c.Id
													and  pl.ParcelaId = pa.Id

--------------------------------------------------------
--------------------------------------------------------
--tabelas geral
select * from [ModeloTelecom].dbo.[Pessoas]
select * from [ModeloTelecom].dbo.[Enderecos]
select * from [ModeloTelecom].dbo.[Contratos]
select * from [ModeloTelecom].dbo.[Parcelas]
select * from [ModeloTelecom].dbo.[PlanoDescricoes]
--select * from [ModeloTelecom].dbo.[TabTelecomConsolidado]

--tabela de ClientePlano,
--para abstrair informações mais detalhas doplano em outra tabela, que nao involva qtd vezes e valores, descoto etc..
--tabela, vai gerar usando migration,


--id plano,
--contratoId    (se precisar de relacinoamneto direto do contrato, sem detalhes da parcela sai direto do contrato para ClientePlano)), relação direta do contrato para plano sem parcelas
--parcelaId     (relacinnar parcela se precisar de dados como valores, parcelas, etc..), 
--NomePlano, 
--DescricaoPlano,
--DescontoPlano, 
--datacadastro, 
--ativo 




--drop table [Pessoas]
--drop table [Contratos]
--drop table [Enderecos] 
--drop table TabTelecomConsolidado
