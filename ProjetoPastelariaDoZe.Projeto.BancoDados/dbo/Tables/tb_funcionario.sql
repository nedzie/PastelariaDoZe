CREATE TABLE [dbo].[tb_funcionario] (
    [id_funcionario] INT           IDENTITY (1, 1) NOT NULL,
    [nome]           VARCHAR (120) NOT NULL,
    [cpf]            CHAR (11)     NOT NULL,
    [matricula]      CHAR (10)     NOT NULL,
    [telefone]       CHAR (11)     NOT NULL,
    [senha]          VARCHAR (200) NOT NULL,
    [grupo]          TINYINT       NOT NULL,
    UNIQUE NONCLUSTERED ([id_funcionario] ASC)
);

