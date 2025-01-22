--METERIAS PRIMAS EQUIPAMIENTO
CREATE TABLE [dbo].[MATERIAS_PRIMAS_EQUIPAMIENTO] (
    [id]                 INT             IDENTITY (1, 1) NOT NULL,
    [id_materia_prima]   INT             NOT NULL,
    [id_equipamiento]    INT             NOT NULL,
    [cantidad_necesaria] DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_MATERIAS_PRIMAS] FOREIGN KEY ([id_materia_prima]) REFERENCES [dbo].[MATERIAS_PRIMAS] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EQUIPAMIENTO] FOREIGN KEY ([id_equipamiento]) REFERENCES [dbo].[EQUIPAMIENTO] ([id]) ON DELETE CASCADE
);
Go