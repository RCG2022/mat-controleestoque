USE Mat_ControleEstoque

DROP TABLE IF EXISTS SystemUser
DROP TABLE IF EXISTS Person

CREATE TABLE Person (
 Id        UNIQUEIDENTIFIER NOT NULL CONSTRAINT Person_Id DEFAULT NEWID(),
 FullName  NVARCHAR(50)     NOT NULL,
 Email     NVARCHAR(50)     NULL,
 Telephone NVARCHAR(20)	    NOT NULL,
 Address   NVARCHAR(500)    NOT NULL
 
 CONSTRAINT PK_Person PRIMARY KEY(Id)
) 

CREATE NONCLUSTERED INDEX IX_Person_001 ON Person (FullName)

GO

INSERT Person (Id, FullName, Email, Telephone, Address)
Values ('0a24e0b6-f5cc-4902-9820-50af6871f225', 'Rauny Stefano Marques', 'rauny.stefano2211@gmail.com', '(11)4488-5020', 'Rua Domingos de Braga, 200')

GO

-- SELECT Person.Id
--   , Person.FullName
-- 	 , Person.Email
-- 	 , Person.Telephone
-- 	 , Person.Address
--   FROM Person WITH(NOLOCK)
--  WHERE Person.Id = '0A24E0B6-F5CC-4902-9820-50AF6871F225'
-- 
--  SELECT Person.Id
--   , Person.FullName
-- 	 , Person.Email
-- 	 , Person.Telephone
-- 	 , Person.Address
--   FROM Person WITH(NOLOCK)
--  WHERE Person.FullName LIKE 'Rauny%'
-- 
--  UPDATE Person
--     SET Person.FullName = 'Rauny Stefano Marques'
--   WHERE Person.Id = '0A24E0B6-F5CC-4902-9820-50AF6871F225'

CREATE TABLE SystemUser (
 Id       UNIQUEIDENTIFIER NOT NULL CONSTRAINT SystemUser_Id DEFAULT NEWID(),
 IdPerson UNIQUEIDENTIFIER NOT NULL,
 Login    VARCHAR(20)      NOT NULL,
 Password VARCHAR(200)     NOT NULL,
 Enabled  BIT              NOT NULL
 
 CONSTRAINT PK_SystemUser     PRIMARY KEY(Id)
 CONSTRAINT FK_SystemUser_001 FOREIGN KEY(IdPerson) REFERENCES Person(Id)
) 

CREATE UNIQUE NONCLUSTERED INDEX UX_SystemUser_001 ON SystemUser(Login)
CREATE UNIQUE NONCLUSTERED INDEX UX_SystemUser_002 ON SystemUser(IdPerson)

CREATE NONCLUSTERED INDEX IX_SystemUser_001 ON SystemUser(Login, Password)

GO

INSERT SystemUser (IdPerson, Login, Password, Enabled)
VALUES ('0a24e0b6-f5cc-4902-9820-50af6871f225', 'RAUNYSMZZ', 'E9CF49C80C4E79FDE373A85F0F9E8C585EF7FCD514C3E506F1DAEE66EDDEDCEF0E427B1A12165BC2C6A68C5411E977D3C5A5DD7FD7E37F3097AEBE0C52FCF76C', '1') 
