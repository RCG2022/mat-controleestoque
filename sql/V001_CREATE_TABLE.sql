USE Mat_ControleEstoque

DROP TABLE IF EXISTS SystemUser
DROP TABLE IF EXISTS Client

CREATE TABLE Client (
 Id        UNIQUEIDENTIFIER NOT NULL CONSTRAINT Client_Id DEFAULT NEWID(),
 FullName  NVARCHAR(50)     NOT NULL,
 Email     NVARCHAR(50)     NULL,
 Telephone NVARCHAR(20)	    NOT NULL,
 Address   NVARCHAR(500)    NOT NULL
 
 CONSTRAINT PK_Client PRIMARY KEY(Id)
) 

CREATE NONCLUSTERED INDEX IX_Client_001 ON Client (FullName)

GO

INSERT Client( Client.Id, Client.FullName, Client.Email, Client.Telephone, Client.Address)
VALUES( '0a24e0b6-f5cc-4902-9820-50af6871f225', 'Rauny Stefano Marques', 'rauny.stefano2211@gmail.com', '(11)4488-5020', 'Rua Domingos de Braga, 200')

INSERT Client (Id, FullName, Email, Telephone, Address)
Values ('6982f837-2147-4a46-83d4-7b9bd2daae1c', 'Julia Miranda candido', 'juliacandidomiranda11@gmail.com', '(11)94818-4777', 'Rua imperatriz Leopoldina 1013')

INSERT Client (Id, FullName, Email, Telephone, Address)
Values ('122f77e6-6549-417a-80a3-82c9056c34cc', 'Sandra Stefano Marques', 'Sandramarques1963@hotmail.com', '(11)98204-7416', 'Rua Domingos de Braga, 200')

GO

CREATE TABLE SystemUser (
 Id       UNIQUEIDENTIFIER NOT NULL CONSTRAINT SystemUser_Id DEFAULT NEWID(),
 Login    VARCHAR(20)      NOT NULL,
 Password VARCHAR(200)     NOT NULL,
 Enabled  BIT              NOT NULL
 
 CONSTRAINT PK_SystemUser     PRIMARY KEY(Id)
) 

CREATE UNIQUE NONCLUSTERED INDEX UX_SystemUser_001 ON SystemUser(Login)

CREATE NONCLUSTERED INDEX IX_SystemUser_001 ON SystemUser(Login, Password)

GO

INSERT SystemUser (Id, Login, Password, Enabled)
VALUES ('122f77e6-6549-417a-80a3-82c9056c34cc', 'RAUNYSMZZ', 'E9CF49C80C4E79FDE373A85F0F9E8C585EF7FCD514C3E506F1DAEE66EDDEDCEF0E427B1A12165BC2C6A68C5411E977D3C5A5DD7FD7E37F3097AEBE0C52FCF76C', '1') 


