USE [Balanca]
GO

/****** Object:  Table [dbo].[SPTB_Movimento]    Script Date: 18/10/2019 10:35:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SPTB_Movimento](
	[Empresa] [int] NOT NULL,
	[Codigo] [int] NOT NULL,
	[CodCliente] [int] NOT NULL,
	[CodVeiculo] [int] NOT NULL,
	[PesoEnt] [float] NOT NULL,
	[HoraEnt] [varchar](6) NOT NULL,
	[DataEnt] [varchar](8) NOT NULL,
	[PesoSai] [float] NULL,
	[HoraSai] [varchar](6) NULL,
	[DataSai] [varchar](8) NULL,
	[Status] [varchar](10) NOT NULL,
	[DataEmissao] [varchar](8) NULL,
	[HoraEmissao] [varchar](6) NULL,
	[NfDocOs] [varchar](20) NULL,
	[Usuario] [varchar](20) NULL,
	[CodFiliado] [int] NULL,
	[CodTransportadora] [int] NOT NULL,
	[StatusCalces] [varchar](10) NOT NULL,
	[Caixa] [varchar](20) NULL,
	[PesoNota] [float] NULL,
	[Serie] [int] NULL,
	[FotoPesagemEntrada] [varchar](1) NULL,
	[FotoPesagemSaida] [varchar](1) NULL,
	[Id_Destino] [int] NULL,
 CONSTRAINT [UK_SPTB_Movimento] UNIQUE NONCLUSTERED 
(
	[Empresa] ASC,
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SPTB_Movimento]  WITH CHECK ADD FOREIGN KEY([Id_Destino])
REFERENCES [dbo].[SPTB_DestinoResiduo] ([Id])
GO

ALTER TABLE [dbo].[SPTB_Movimento]  WITH CHECK ADD  CONSTRAINT [CK_SPTB_Movimento_Status] CHECK  (([Status]='PENDENTE' OR [Status]='ATUALIZADO' OR [Status]='CANCELADO'))
GO

ALTER TABLE [dbo].[SPTB_Movimento] CHECK CONSTRAINT [CK_SPTB_Movimento_Status]
GO



select * from SPTB_Movimento