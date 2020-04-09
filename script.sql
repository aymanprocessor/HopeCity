-- Script Date: 4/8/2020 10:47 PM  - ErikEJ.SqlCeScripting version 3.5.2.86
-- Database information:
-- Locale Identifier: 1033
-- Encryption Mode: Platform Default
-- Case Sensitive: False
-- Database: F:\Code_Project\C#\HopeCity\HopeCity\HopeCity\hopecity_db.sdf
-- ServerVersion: 4.0.8482.1
-- DatabaseSize: 128 KB
-- SpaceAvailable: 3.999 GB
-- Created: 3/13/2020 7:34 PM

-- User Table information:
-- Number of tables: 3
-- QA: 0 row(s)
-- son: 0 row(s)
-- users: 1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [users] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [username] nvarchar(50) NULL COLLATE NOCASE
, [password] nvarchar(50) NULL COLLATE NOCASE
, [role] nvarchar(50) NULL COLLATE NOCASE
);
CREATE TABLE [son] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [date] nvarchar(50) NULL COLLATE NOCASE
, [name] nvarchar(50) NULL COLLATE NOCASE
, [gender] nvarchar(50) NULL COLLATE NOCASE
, [dob] nvarchar(50) NULL COLLATE NOCASE
, [age] nvarchar(50) NULL COLLATE NOCASE
, [nat] nvarchar(50) NULL COLLATE NOCASE
, [nos] nvarchar(50) NULL COLLATE NOCASE
, [orderrr] nvarchar(50) NULL COLLATE NOCASE
, [address] nvarchar(50) NULL COLLATE NOCASE
, [djob] nvarchar(50) NULL COLLATE NOCASE
, [dedu] nvarchar(50) NULL COLLATE NOCASE
, [daddress] nvarchar(50) NULL COLLATE NOCASE
, [dtelephone] nvarchar(50) NULL COLLATE NOCASE
, [dmobile] nvarchar(50) NULL COLLATE NOCASE
, [mname] nvarchar(50) NULL COLLATE NOCASE
, [mjob] nvarchar(50) NULL COLLATE NOCASE
, [medu] nvarchar(50) NULL COLLATE NOCASE
, [maddress] nvarchar(50) NULL COLLATE NOCASE
, [mmobile] nvarchar(50) NULL COLLATE NOCASE
, [withdad] bit NULL
, [withmom] bit NULL
, [withother] bit NULL
, [whocare] nvarchar(50) NULL COLLATE NOCASE
, [problem] nvarchar(50) NULL COLLATE NOCASE
);
CREATE TABLE [QA] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Question] nvarchar(100) NULL COLLATE NOCASE
, [QAnswer] nvarchar(100) NULL COLLATE NOCASE
, [SubQuestion] nvarchar(100) NULL COLLATE NOCASE
, [SQAnswer] nvarchar(100) NULL COLLATE NOCASE
, [sonId] int NULL
, CONSTRAINT [FK_QA_son] FOREIGN KEY ([sonId]) REFERENCES [son] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
INSERT INTO [users] ([Id],[username],[password],[role]) VALUES (
1,'admin','admin','administrator');
CREATE TRIGGER [fki_QA_sonId_son_Id] BEFORE Insert ON [QA] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table QA violates foreign key constraint FK_QA_son') WHERE NEW.sonId IS NOT NULL AND(SELECT Id FROM son WHERE  Id = NEW.sonId) IS NULL; END;
CREATE TRIGGER [fku_QA_sonId_son_Id] BEFORE Update ON [QA] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table QA violates foreign key constraint FK_QA_son') WHERE NEW.sonId IS NOT NULL AND(SELECT Id FROM son WHERE  Id = NEW.sonId) IS NULL; END;
COMMIT;

