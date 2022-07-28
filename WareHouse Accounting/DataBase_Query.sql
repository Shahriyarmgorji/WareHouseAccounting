--==================================
-- Write : shahriyar Mohammadi Gorji
-- Start Date : Julay ,28 , 2022
--==================================

CREATE DATABASE WareHouseAccounting
ON   
( NAME = WareHouseAccounting,  
    FILENAME = 'I:\My Project\WareHouseAccounting\WareHouse Accounting\DataBase\WareHouseAccounting.mdf',  
    SIZE = 10240KB,  
    MAXSIZE = 51200KB,  
    FILEGROWTH = 5 )  
LOG ON  
( NAME = WareHouseAccounting_log,  
    FILENAME = 'I:\My Project\WareHouseAccounting\WareHouse Accounting\DataBase\WareHouseAccounting_log.ldf',  
    SIZE = 10MB,  
    MAXSIZE = UNLIMITED,  
    FILEGROWTH = 5MB );  
GO
USE WareHouseAccounting
GO
--==================================================================
Create Table Setiing
(
Setiing_Id					INT				NOT NULL		IDENTITY(1,1)	PRIMARY KEY	,


LastEditDateTime			DateTime		NOT NULL	DEFAULT(GETDATE())
)

Create Table [Role]
(
Role_Id					INT				NOT NULL		IDENTITY(1,1)	PRIMARY KEY	,
RoleName				NVARCHAR(50)		NULL,
DepotPermission			BIT					NULL,
BankPermission			BIT					NULL,
PersonPermission		BIT					NULL,
FactorPermission		BIT					NULL,
UserrPermission			BIT					NULL,
SetingPermission		BIT					NULL,
LastEditDateTime		DateTime		NOT NULL	DEFAULT(GETDATE())
)