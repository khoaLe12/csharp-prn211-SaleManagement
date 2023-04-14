-- migration by EF with cli : 
-- dotnet ef database update Init
-- or using this script 
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'assignment02'
)
CREATE DATABASE assignment02
GO

use assignment02

-- Create a new table called '[member]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Member]', 'U') IS NOT NULL
DROP TABLE [dbo].[Member]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Member]
(
    [MemberId] INT NOT NULL PRIMARY KEY IDENTITY, -- Primary Key column
    [Email] VARCHAR(100) NOT NULL,
    [CompanyName] VARCHAR(40) NOT NULL,
    [City] varchar(15) NOT NULL,
    [Country] varchar(15) NOT NULL,
    [Password] varchar(30) NOT NULL
    -- Specify more columns here
);
GO

-- Create a new table called '[Order]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Order]', 'U') IS NOT NULL
DROP TABLE [dbo].[Order]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Order]
(
    [OrderId] INT NOT NULL PRIMARY KEY IDENTITY, -- Primary Key column
    [MemberId] INT NOT NULL ,
    [OrderDate] DATETIME NOT NULL ,
    [RequiredDate] DATETIME ,
    [ShippedDate] DATETIME ,
    [Freight] money,
    -- Specify more columns here
    FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
);
GO

-- Create a new table called '[Product]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Product]', 'U') IS NOT NULL
DROP TABLE [dbo].[Product]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Product]
(
    [ProductId] INT NOT NULL PRIMARY KEY IDENTITY, -- Primary Key column
    [CategoryId] INT NOT NULL,
    [ProductName] VARCHAR(40) NOT NULL,
    [Weight] VARCHAR(20) NOT NULL,
    [UnitPrice] money NOT NULL,
    [UnitsInStock] int NOT NULL
    -- Specify more columns here
);
GO

-- Create a new table called '[OrderDetail]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[OrderDetail]', 'U') IS NOT NULL
DROP TABLE [dbo].[OrderDetail]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[OrderDetail]
(
    [OrderId] INT NOT NULL  , -- Primary Key column
    [ProductId] int NOT NULL,
    [UnitPrice] int NOT NULL,
    [Quantity] int NOT NULL,
    [Discount] float NOT NULL,
    CONSTRAINT PK_OrderDetail PRIMARY KEY(OrderId,ProductId),
    -- Specify more columns here
    FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
    FOREIGN KEY (ProductId) REFERENCES [Product](ProductId)
);
GO

-- INSERT MOCKUP DATA 
INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('Cake',1,20000,300,0.5);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('Pepsi',2,8000,1000,0.4);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('Coca',2,7000,1000,0.4);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('7 Up',2,9000,1000,0.45);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('Monster',2,30000,1000,0.53);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('Nike AF1',3,1600000,99,1);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('Yeezy 350v1 Oxford Tan',3,20000000,5,1.5);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('Yeezy 700 Waverunner',3,9000000,5,1.5);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('IPhone 13 Pro Max',5,25000000,50,1.5);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('IPhone 14 Pro Max',5,40000000,50,1.5);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('IPhone 14',5,30000000,50,1.5);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('Macbook Air M2',6,30000000,50,1.5);

INSERT INTO dbo.Product (ProductName,CategoryId,UnitPrice,UnitsInStock,Weight)
VALUES ('MacbookPro M2',6,36000000,50,2.5);

GO

-- Insert rows into table 'member' in schema '[dbo]'
INSERT INTO [dbo].[member]
( -- Columns to insert data into
 [Email],CompanyName, City,Country,Password
)
VALUES
( -- First row: values for the columns in the list above
 'phong@email.com', 'Nash', 'HCM','Vietnam','123'
),
( -- First row: values for the columns in the list above
 'nam@email.com', 'Nash', 'HCM','Vietnam','123'
),
( -- First row: values for the columns in the list above
 'hoang@email.com', 'NAB', 'Hanoi','Vietnam','123'
),
( -- First row: values for the columns in the list above
 'loc@email.com', 'ELCA', 'dwd','Vietnam','123'
)



-- Select rows from a Table or View '[product]' in schema '[dbo]'
SELECT * FROM [dbo].[product]


-- Add more rows here
GO

-- Insert rows into table 'order' in schema '[dbo]'
INSERT INTO [dbo].[order]
( -- Columns to insert data into
 MemberId,OrderDate,RequiredDate,ShippedDate,Freight
)
VALUES
( -- First row: values for the columns in the list above
 1, '11-14-2022', '11-15-2022','11-17-2022',40000
),
( -- First row: values for the columns in the list above
 2, '10-22-2022', '11-10-2022','11-13-2022',70000
),
( -- First row: values for the columns in the list above
 3, '11-02-2022', '11-03-2022','11-05-2022',60000
),
( -- First row: values for the columns in the list above
 4, '11-01-2022', '11-03-2022','11-07-2022',50000
)


INSERT INTO [dbo].[OrderDetail]
( -- Columns to insert data into
    OrderId, ProductId, UnitPrice, Quantity, Discount
)
VALUES
( -- First row: values for the columns in the list above
 1,1,20000,4,0.15
),
( -- First row: values for the columns in the list above
 1,2,8000,3,0.1
),
( -- First row: values for the columns in the list above
 2,3,7000,2,0
),
( -- First row: values for the columns in the list above
 2,4,40000,2,0
),
( -- First row: values for the columns in the list above
 2,5,30000,3,0.1
),
( -- First row: values for the columns in the list above
 2,7,9000000,2,0.1
),
( -- First row: values for the columns in the list above
 3,11,30000000,10,0.1
),
( -- First row: values for the columns in the list above
 3,10,40000000,4,0.1
),
( -- First row: values for the columns in the list above
 3,13,36000000,3,0.1
),
( -- First row: values for the columns in the list above
 4,12,30000000,1,0
),
( -- First row: values for the columns in the list above
 4,7,20000000,1,0
),
( -- First row: values for the columns in the list above
 4 ,4,9000,4,0.1
)

-- Add more rows here
GO