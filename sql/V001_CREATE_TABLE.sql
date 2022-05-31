USE Mat_ControleEstoque

DROP TABLE IF EXISTS SystemUser
DROP TABLE IF EXISTS Client
DROP TABLE IF EXISTS ShoppingCart
DROP TABLE IF EXISTS Purchase
DROP TABLE IF EXISTS Sale
DROP TABLE IF EXISTS Product


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
VALUES ('122f77e6-6549-417a-80a3-82c9056c34cc', 'ADMIN', 'E9CF49C80C4E79FDE373A85F0F9E8C585EF7FCD514C3E506F1DAEE66EDDEDCEF0E427B1A12165BC2C6A68C5411E977D3C5A5DD7FD7E37F3097AEBE0C52FCF76C', '1') 

INSERT SystemUser (Id, Login, Password, Enabled)
VALUES ('498c3eaf-adff-4b88-aeb5-f749c8d77846', 'RAUNYSMZZ', 'E9CF49C80C4E79FDE373A85F0F9E8C585EF7FCD514C3E506F1DAEE66EDDEDCEF0E427B1A12165BC2C6A68C5411E977D3C5A5DD7FD7E37F3097AEBE0C52FCF76C', '1') 

INSERT SystemUser (Id, Login, Password, Enabled)
VALUES ('a31c3728-b172-49c4-a971-4886fb3355cc', 'CESAR', 'E9CF49C80C4E79FDE373A85F0F9E8C585EF7FCD514C3E506F1DAEE66EDDEDCEF0E427B1A12165BC2C6A68C5411E977D3C5A5DD7FD7E37F3097AEBE0C52FCF76C', '1') 

GO

CREATE TABLE Product (
 Id             UNIQUEIDENTIFIER NOT NULL CONSTRAINT Product_Id DEFAULT NEWID(),
 Name           NVARCHAR(50)     NOT NULL,
 Indentifier    NVARCHAR(300)    NULL,
 Detail         NVARCHAR(MAX)    NULL,
 MinimumPurchase   INT              NOT NULL,
 Price          DECIMAL(10,2)    NOT NULL
 
 CONSTRAINT PK_Product PRIMARY KEY(Id)
) 

CREATE NONCLUSTERED INDEX IX_Product_001 ON Product (Name, Indentifier)

GO

INSERT Product (Id, Name, Indentifier, MinimumPurchase, Price)
VALUES ('b1a034c9-c0ce-4281-b868-ae6d8b6b5ad5', 'Mouse',  'M2341', 5, 39.99) 

INSERT Product (Id, Name, Indentifier, MinimumPurchase, Price)
VALUES ('fb588561-e29c-43d5-926a-fdd0888e7c67', 'Teclado',  'M2342', 5, 49.99) 

GO

CREATE TABLE Purchase (
 Id        UNIQUEIDENTIFIER NOT NULL CONSTRAINT Purchase_Id DEFAULT NEWID(),
 IdProduct UNIQUEIDENTIFIER NOT NULL,
 Quantity  INT              NOT NULL,
 PriceCost DECIMAL(10,2)    NOT NULL,
 DateTime  Date             NOT NULL
 
 CONSTRAINT PK_Purchase PRIMARY KEY(Id)
 CONSTRAINT FK_Purchase_001 FOREIGN KEY(IdProduct) REFERENCES Product(Id)
)

GO

INSERT Purchase (Id, IdProduct, Quantity, PriceCost, DateTime)
VALUES ('f6cfc2df-a082-49bf-be73-9b31e36d9426', 'b1a034c9-c0ce-4281-b868-ae6d8b6b5ad5', 100,  20, '2022-05-10') 

INSERT Purchase (Id, IdProduct, Quantity, PriceCost, DateTime)
VALUES ('f4cf051f-3de9-4c89-a33a-ad38a844ac48', 'fb588561-e29c-43d5-926a-fdd0888e7c67', 100,  25, '2022-05-11') 

GO

CREATE TABLE Sale (
 Id       UNIQUEIDENTIFIER NOT NULL CONSTRAINT Sale_Id DEFAULT NEWID(),
 IdClient UNIQUEIDENTIFIER NOT NULL,
 DateTime Date             NOT NULL
 
 CONSTRAINT PK_Sale PRIMARY KEY(Id)
)

GO

INSERT Sale (Id, IdClient, DateTime)
VALUES ('f6cfc2df-a082-49bf-be73-9b31e36d9426', '6982f837-2147-4a46-83d4-7b9bd2daae1c', '2022-05-13') 

CREATE TABLE ShoppingCart (
 Id        UNIQUEIDENTIFIER NOT NULL CONSTRAINT ShoppingCart_Id DEFAULT NEWID(),
 IdProduct UNIQUEIDENTIFIER NOT NULL,
 IdSale    UNIQUEIDENTIFIER NOT NULL,
 Quantity  INT              NOT NULL,
 Discount  DECIMAL(10,2)    NOT NULL
 
 CONSTRAINT PK_ShoppingCart PRIMARY KEY(Id),
 CONSTRAINT FK_ShoppingCart_001 FOREIGN KEY(IdProduct) REFERENCES Product(Id),
 CONSTRAINT FK_ShoppingCart_002 FOREIGN KEY(IdSale)    REFERENCES Sale(Id)
)

GO

INSERT ShoppingCart (Id, IdProduct, IdSale, Quantity, Discount)
VALUES ('1d861689-a282-4b49-a672-04ed524e151a', 'b1a034c9-c0ce-4281-b868-ae6d8b6b5ad5', 'f6cfc2df-a082-49bf-be73-9b31e36d9426', 1,  0) 

INSERT ShoppingCart (Id, IdProduct, IdSale, Quantity, Discount)
VALUES ('cc5f8131-3822-4f89-9695-8f401a9927f7', 'fb588561-e29c-43d5-926a-fdd0888e7c67', 'f6cfc2df-a082-49bf-be73-9b31e36d9426', 2,  2) 

select *, Product.Price - ShoppingCart.Discount as PriceDiscount, (Product.Price - ShoppingCart.Discount) * ShoppingCart.Quantity as Total  from sale
join ShoppingCart on (sale.id = ShoppingCart.IdSale)
join Product on (Product.id = ShoppingCart.IdProduct)
