/**
 Precisa ao menos criar a tabela do vxTel 
**/



USE [VxTel]
GO

DROP TABLE [dbo].[TarifaTelefonia]
GO

CREATE TABLE [dbo].[TarifaTelefonia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HASHCODE] [uniqueidentifier] NOT NULL,
	[DDD_ORIGEM] [int] NOT NULL,
	[DDD_DESTINO] [int] NOT NULL,
	[PRECO_MINUTO] [decimal](3, 2) NOT NULL,
	[DATA_CRIACAO] [datetime] NOT NULL,
	[DATA_ALTERACAO] [datetime] NOT NULL,
 CONSTRAINT [PK_TarifaTelefonia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

DROP TABLE [dbo].[PlanoTelefonia]
GO

CREATE TABLE [dbo].[PlanoTelefonia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HASHCODE] [uniqueidentifier] NOT NULL,
	[TIPO] [int] NOT NULL,
	[MinutoPlano] [int] NOT NULL,
	[TaxaAcrescimo] [decimal](18, 2) NOT NULL,
	[DATA_CRIACAO] [datetime] NOT NULL,
	[DATA_ALTERACAO] [datetime] NOT NULL,
 CONSTRAINT [PK_PlanoTelefonia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT INTO TarifaTelefonia  VALUES(newid(),11,16,1.90,getdate(),getdate())
INSERT INTO TarifaTelefonia  VALUES(newid(),16,11,2.90,getdate(),getdate())
INSERT INTO TarifaTelefonia  VALUES(newid(),11,17,1.70,getdate(),getdate())
INSERT INTO TarifaTelefonia  VALUES(newid(),17,11,2.70,getdate(),getdate())
INSERT INTO TarifaTelefonia  VALUES(newid(),11,18,0.90,getdate(),getdate())
INSERT INTO TarifaTelefonia  VALUES(newid(),18,11,1.90,getdate(),getdate())


INSERT INTO PlanoTelefonia values(NEWID(),1,30,10,getdate(),getdate())
INSERT INTO PlanoTelefonia values(NEWID(),2,60,10,getdate(),getdate())
INSERT INTO PlanoTelefonia values(NEWID(),3,120,10,getdate(),getdate())
INSERT INTO PlanoTelefonia values(NEWID(),0,0,0,getdate(),getdate())

