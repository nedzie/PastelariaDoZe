CREATE TABLE [dbo].[tb_comanda] (
    [id_comanda]            INT           IDENTITY (1, 1) NOT NULL,
    [comanda]               VARCHAR (MAX) NOT NULL,
    [data_hora]             DATETIME      NOT NULL,
    [status_comanda]        TINYINT       NOT NULL,
    [status_pagamento]      TINYINT       NULL,
    [data_assinatura_fiado] DATE          NULL,
    [funcionario_id]        INT           NULL,
    [cliente_id]            INT           NULL,
    CONSTRAINT [PK_tb_comanda] PRIMARY KEY CLUSTERED ([id_comanda] ASC),
    CONSTRAINT [FK_cliente_id] FOREIGN KEY ([cliente_id]) REFERENCES [dbo].[tb_cliente] ([id_cliente]),
    CONSTRAINT [FK_funcionario_id] FOREIGN KEY ([funcionario_id]) REFERENCES [dbo].[tb_funcionario] ([id_funcionario])
);

