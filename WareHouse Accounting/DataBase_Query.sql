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
-- ========================		TABLES		========================
Create Table Settings
(
Setiing_Id								INT					NOT NULL		IDENTITY(1,1)	PRIMARY KEY	,
CompanyName								NVARCHAR(100)			NULL,
AddressOfInvoices						NVARCHAR(MAX)			NULL,
WarehouseRemittanceAddress				NVARCHAR(MAX)			NULL,
ContactNumberOfInvoices					NVARCHAR(20)			NULL,
WarehouseRemittanceContactNumber		NVARCHAR(20)			NULL,
SMSPanelUserName						NVARCHAR(20)			NULL,					
SMSPanelPassword						NVARCHAR(20)			NULL,
SMSRecipientNumber						NVARCHAR(11)			NULL,
SMSSender								NVARCHAR(20)			NULL,
WarningCameFrom							INT						NULL,
WarningCameTo							INT						NULL,
SendSMSForTransactions					BIT						NULL,
SendSMSForInvoices						BIT						NULL,
LastEditDateTime						DateTime				NOT NULL	DEFAULT(GETDATE())
)

Create Table Roles
(
Role_Id					INT					NOT NULL		IDENTITY(1,1)	PRIMARY KEY	,
RoleName				NVARCHAR(50)		NULL,
DepotPermission			BIT					NULL,
BankPermission			BIT					NULL,
PersonPermission		BIT					NULL,
FactorPermission		BIT					NULL,
SettingPermission		BIT					NULL,
UserPermission			BIT					NULL,
LastEditDateTime		DateTime			NOT NULL	DEFAULT(GETDATE())
)
GO

--===================================================================================
-- =================	STORED PROCEDURES	=================
--==========================		Start PROCEDURE FOR Settings			--==========================

CREATE PROCEDURE InsertSettings
@CompanyName							NVARCHAR(100),
@AddressOfInvoices						NVARCHAR(MAX),
@WarehouseRemittanceAddress				NVARCHAR(MAX),
@ContactNumberOfInvoices				NVARCHAR(20),
@WarehouseRemittanceContactNumber		NVARCHAR(20),
@SMSPanelUserName						NVARCHAR(20),
@SMSPanelPassword						NVARCHAR(20),
@SMSRecipientNumber						NVARCHAR(11),
@SMSSender								NVARCHAR(20),
@WarningCameFrom						INT,
@WarningCameTo							INT,
@SendSMSForTransactions					BIT,
@SendSMSForInvoices						BIT,
@LastEditDateTime						DateTime
AS
BEGIN
INSERT INTO Settings
VALUES(
@CompanyName,
@AddressOfInvoices,
@WarehouseRemittanceAddress,
@ContactNumberOfInvoices,
@WarehouseRemittanceContactNumber,
@SMSPanelUserName,
@SMSPanelPassword,
@SMSRecipientNumber,
@SMSSender,
@WarningCameFrom,
@WarningCameTo,
@SendSMSForTransactions,
@SendSMSForInvoices,
@LastEditDateTime
)
END
GO

CREATE PROCEDURE UpdateSettings
@CompanyName							NVARCHAR(100),
@AddressOfInvoices						NVARCHAR(MAX),
@WarehouseRemittanceAddress				NVARCHAR(MAX),
@ContactNumberOfInvoices				NVARCHAR(20),
@WarehouseRemittanceContactNumber		NVARCHAR(20),
@SMSPanelUserName						NVARCHAR(20),
@SMSPanelPassword						NVARCHAR(20),
@SMSRecipientNumber						NVARCHAR(11),
@SMSSender								NVARCHAR(20),
@WarningCameFrom						INT,
@WarningCameTo							INT,
@SendSMSForTransactions					BIT,
@SendSMSForInvoices						BIT,
@LastEditDateTime						DateTime
AS
BEGIN
UPDATE Settings
SET
CompanyName								= @CompanyName,
AddressOfInvoices					 	= @AddressOfInvoices,
WarehouseRemittanceAddress				= @WarehouseRemittanceAddress,
ContactNumberOfInvoices					= @ContactNumberOfInvoices,
WarehouseRemittanceContactNumber		= @WarehouseRemittanceContactNumber,
SMSPanelUserName						= @SMSPanelUserName,
SMSPanelPassword						= @SMSPanelPassword,
SMSRecipientNumber						= @SMSRecipientNumber,
SMSSender								= @SMSSender,
WarningCameFrom							= @WarningCameFrom,
WarningCameTo							= @WarningCameTo,
SendSMSForTransactions					= @SendSMSForTransactions,
SendSMSForInvoices						= @SendSMSForInvoices,
LastEditDateTime						= @LastEditDateTime
END
GO

CREATE PROCEDURE FiLLSettings
AS
BEGIN
SELECT * fROM Settings
END
GO

CREATE PROCEDURE ExistSettings
-- =============		Checking if the desired value exists or not		=============
@Exist		BIT		OUTPUT
AS
BEGIN
SELECT @Exist = (SELECT COUNT(*) FROM Settings)
END
GO
--==========================		ٍEND PROCEDURE FOR Settings			--==========================
--==========================		Start PROCEDURE FOR Roles			--==========================
CREATE PROCEDURE InsertRoles
@RoleName								NVARCHAR(100),
@DepotPermission						BIT,
@BankPermission							BIT,
@PersonPermission						BIT,
@FactorPermission						BIT,
@SettingPermission						BIT,
@UserPermission							BIT,
@LastEditDateTime						DateTime
AS
BEGIN
INSERT INTO Roles
VALUES(
@RoleName,
@DepotPermission,
@BankPermission,
@PersonPermission,
@FactorPermission,
@SettingPermission,
@UserPermission,
@LastEditDateTime
)
END
GO

CREATE PROCEDURE UpdateRoles
@RolesId								INT,
@RoleName								NVARCHAR(100),
@DepotPermission						BIT,
@BankPermission							BIT,
@PersonPermission						BIT,
@FactorPermission						BIT,
@SettingPermission						BIT,
@UserPermission							BIT,
@LastEditDateTime						DateTime
AS
BEGIN
Update Roles
SET
RoleName								= @RoleName,
DepotPermission					 		= @DepotPermission,
BankPermission							= @BankPermission,
PersonPermission						= @PersonPermission,
FactorPermission						= @FactorPermission,
SettingPermission						= @SettingPermission,
UserPermission							= @UserPermission,
LastEditDateTime						= @LastEditDateTime
END
GO

CREATE PROCEDURE DeleteRoles
@Role_Id		INT
AS
BEGIN
DELETE  FROM Roles
WHERE Role_Id = @Role_Id
END
GO
CREATE PROCEDURE FillRolesByRoleID
@Role_Id		INT
AS
BEGIN
SELECT * FROM Roles Where Role_Id = @Role_Id
ORDER BY RoleName 
END
GO

CREATE PROCEDURE FillRoles
AS
BEGIN
SELECT * FROM Roles
ORDER BY RoleName 
END
GO


CREATE PROCEDURE ExistRoles
@Exist		BIT		OUTPUT
AS
BEGIN
SET @Exist =(SELECT COUNT(*) FROM Roles)
END
GO

--==========================		ٍEND PROCEDURE FOR Roles				--==========================
