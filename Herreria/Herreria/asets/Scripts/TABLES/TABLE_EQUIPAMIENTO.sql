--EQUIPAMIENTO
CREATE TABLE [dbo].[EQUIPAMIENTO] (
    [id]                 INT             IDENTITY (1, 1) NOT NULL,
    [nombre]             NVARCHAR (100)  NOT NULL,
    [tiempo_elaboracion] INT             NOT NULL,
    [precio_venta]       DECIMAL (10, 2) NOT NULL,
    [tipo]               NVARCHAR (50)   NOT NULL,
    [peso]               DECIMAL (10, 2) NOT NULL,
    [descripcion]        NVARCHAR (MAX)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
Go