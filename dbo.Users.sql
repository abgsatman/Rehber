﻿CREATE TABLE [dbo].[Users] (
    [Id]          INT           NOT NULL,
    [FirstName]   NVARCHAR (50) NULL,
    [LastName]    NVARCHAR (50) NULL,
    [MobilePhone] NCHAR (10)    NULL,
    [Email]       NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

