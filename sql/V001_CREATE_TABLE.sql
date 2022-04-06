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

INSERT Person
     ( Person.Id
	 , Person.FullName
	 , Person.Email
	 , Person.Telephone
	 , Person.Address
	 )
VALUES
     ( '0a24e0b6-f5cc-4902-9820-50af6871f225'
	 , 'Rauny Stefano Marques'
	 , 'rauny.stefano2211@gmail.com'
	 , '(11)4488-5020'
	 , 'Rua Domingos de Braga, 200'
	 )

INSERT Person (Id, FullName, Email, Telephone, Address)
Values ('6982f837-2147-4a46-83d4-7b9bd2daae1c', 'Julia Miranda candido', 'juliacandidomiranda11@gmail.com', '(11)94818-4777', 'Rua imperatriz Leopoldina 1013')

INSERT Person (Id, FullName, Email, Telephone, Address)
Values ('122f77e6-6549-417a-80a3-82c9056c34cc', 'Sandra Stefano Marques', 'Sandramarques1963@hotmail.com', '(11)98204-7416', 'Rua Domingos de Braga, 200')

GO

 --SELECT Person.Id
 --     , Person.FullName
 --	  , Person.Email
 --	  , Person.Telephone
	--  , Person.Address
 --  FROM Person WITH(NOLOCK)
 -- WHERE Person.Id = ''           -- Buscar da tabela Person pelo ID      
 
 --SELECT Person.Id
 --     , Person.FullName
 --	  , Person.Email
 --	  , Person.Telephone
	--  , Person.Address
 --  FROM Person WITH(NOLOCK)
 -- WHERE Person.FullName LIKE ''  -- Buscar da tabela Person pelo FullName
 
 -- UPDATE Person
 --    SET Person.FullName = ''    -- Dar update no dado escolhido(fullname)
 --  WHERE Person.Id = ''          -- Colocar o id de quem vc quer trocar o dado para não trocar da pessoa errada   

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

 --SELECT SystemUser.Id
	--  , SystemUser.Login
	--  , SystemUser.Password
 --  FROM SystemUser WITH(NOLOCK)
 -- WHERE SystemUser.Id = ''       -- Buscar da tabela SystemUser pelo ID

 --SELECT SystemUser.Id
	--  , SystemUser.Login
	--  , SystemUser.Password
 --  FROM SystemUser WITH(NOLOCK)
 -- WHERE SystemUser.Login = ''    -- Buscar da tabela SystemUser pelo LOGIN

 --UPDATE SystemUser
 --   SET SystemUser.Login = ''    -- Dar update no dado escolhido(LOGIN)
 -- WHERE SystemUser.Id = ''       -- Colocar o id de quem vc quer trocar o dado para não trocar da pessoa errada

 -- UPDATE SystemUser
 --   SET SystemUser.Password = '' -- Dar update no dado escolhido(Password)
 -- WHERE SystemUser.Id = ''       -- Colocar o id de quem vc quer trocar o dado para não trocar da pessoa errada

INSERT SystemUser (IdPerson, Login, Password, Enabled)
VALUES ('0a24e0b6-f5cc-4902-9820-50af6871f225', 'RAUNYSMZZ', 'E9CF49C80C4E79FDE373A85F0F9E8C585EF7FCD514C3E506F1DAEE66EDDEDCEF0E427B1A12165BC2C6A68C5411E977D3C5A5DD7FD7E37F3097AEBE0C52FCF76C', '1') 

