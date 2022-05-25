USE [ModeloTelecom]
GO

/****** Object: Table [dbo].[TabTelecomConsolidado] Script Date: 28/04/2022 17:41:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TabTelecomConsolidado] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Dia]           DATE            NULL,
    [Fila]          INT             NULL,
    [Terminator]    VARCHAR (100)   NULL,
    [StatusInicial] VARCHAR (255)   NULL,
    [StatusFinal]   VARCHAR (100)   NOT NULL,
    [Disparos]      INT             NOT NULL,
    [Custo]         DECIMAL (18, 2) NOT NULL,
    [Servidor]      VARCHAR (100)   NULL
);



drop table [TabTelecomConsolidado]

select * from  [TabTelecomConsolidado]


--carga para dados para testar
1	2022-04-05	4444	Algar Fagner	MACHINE	MACHINE	72656	17220.00	SrvCar
2	2022-04-06	5000	Algar	        MACHINE	REDIR	78956	25220.00	SrvCar2
3	2022-04-07	9999	Vault 12	    MACHINE	REDIR	78954	45623.00	SrvCar3
4	2022-04-07	8888	Apollo 12	    MACHINE	REDIR	89546	95624.00	SrvCar3
5	2022-04-07	8888	Apollo 12	    MACHINE	REDIR	89546	95624.00	SrvCar3
6	2022-04-07	7777	VAVEM 12	    MACHINE	REDIR	96325	74125.00	SrvCar4
7	2022-04-08	3333	Vault 12	    MACHINE	REDIR	75862	63527.00	SrvCar3
8	2022-04-07	6666	Fagner telecom	MACHINE	MACHINE	98985	95959.00	SrvCar10
10	2022-04-07	9999	error	error	error	        99999	99999.00	error


