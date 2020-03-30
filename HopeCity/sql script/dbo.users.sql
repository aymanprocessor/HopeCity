USE [C:\USERS\LENOVO\DESKTOP\HOPECITY\HOPECITY\HOPECITY\HCDB1.MDF]
GO

/****** Object: Table [dbo].[users] Script Date: 05-Mar-20 6:05:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (50) NULL,
    [password] NVARCHAR (50) NULL
);


