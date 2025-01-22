--MATERIAS PRIMAS
CREATE TABLE [dbo].[MATERIAS_PRIMAS] (
    [id]            INT             IDENTITY (1, 1) NOT NULL,
    [nombre]        NVARCHAR (100)  NOT NULL,
    [peso]          DECIMAL (10, 2) NOT NULL,
    [precio_compra] DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
Go