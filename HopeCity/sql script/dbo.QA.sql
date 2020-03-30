USE [C:\USERS\LENOVO\DESKTOP\HOPECITY\HOPECITY\HOPECITY\HCDB1.MDF]
GO

/****** Object: Table [dbo].[QA] Script Date: 05-Mar-20 6:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[QA] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Question]    NVARCHAR (100) NULL,
    [QAnswer]     NVARCHAR (100) NULL,
    [SubQuestion] NVARCHAR (100) NULL,
    [SQAnswer]    NVARCHAR (100) NULL,
    [sonId]       INT            NULL
);


