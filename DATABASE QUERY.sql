
CREATE DATABASE DBSalesandInventory
GO

USE DBSalesandInventory
GO


/* User Management Module*/

CREATE TABLE tblUsers(
	[UserID] [int] IDENTITY(1,1) PRIMARY KEY,
	[Name] [varchar](100) NULL,
	[Username] [varchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Status] [varchar](50) NULL,
	[RoleID] [int] NULL,
	)

CREATE TABLE tblRoles(
	[RoleID] [int] IDENTITY(1,1) PRIMARY KEY,
	[Role] [varchar](50) NULL,
	)


/* Product Management Module*/

CREATE TABLE tblProducts(
	[ProductID] [int] IDENTITY(1,1) PRIMARY KEY,
	[ProductCode] [varchar](100) NULL,
	[ProductDesc] [varchar](max) NULL,
	[ProductVariety] [varchar](100) NULL,
	[Price] [decimal](18, 2) NULL,
	)


/* Inventory Management Module*/

 CREATE TABLE tblStockin(
	[stockinID] [int] IDENTITY(1,1) PRIMARY KEY,
	[ProductID] [int] NULL,
	[QtyStockedIn] [int] NULL,
	[StockinDate] [datetime] NULL,
	[RestockLevel] [int], NULL
	[BatchID] [int] NULL,
	)


 CREATE TABLE tblStockout(
	[StockoutID] [int] IDENTITY(1,1) PRIMARY KEY,
	[ProductID] [int] NULL,
	[QtyStockedOut] [int] NULL,
	[PurchaseID] [int] NULL,
	[StockoutDate] [datetime] NULL,
	[BatchID] [int] NULL,
	)


CREATE TABLE tblBatch(
	[BatchID] [int] IDENTITY(1,1) PRIMARY KEY,
	[MillingDate] [datetime] NULL,
	)


CREATE TABLE tblBatchProduct(
	[ID][int] IDENTITY(1,1) PRIMARY KEY,
	[BatchID] [int] NULL,
	[BatchNumber] [int] NULL,
	[Status] [datetime] NULL,
	)




/* Sales Management Module*/

CREATE TABLE tblDiscount(
	[DiscountID] [int] IDENTITY(1,1) PRIMARY KEY,
	[DiscountName] [varchar](50) NULL,
	[DiscountPercentage] [float] NULL,
 )

CREATE TABLE tblPayments(
	[PaymentID] [int] IDENTITY(1,1) PRIMARY KEY,
	[TotalAmount] [decimal](18, 2) NULL,
	[AmountPaid] [decimal](18, 2) NULL,

	)

CREATE TABLE tblTransactions(
	[TransactionID] [int] IDENTITY(1,1) PRIMARY KEY,
        [TransactionDate] [datetime] NULL,
	[PurchaseID] [int] NULL,
	[UserID] [int] NULL,
	)

CREATE TABLE tblPurchases(
	[PurchaseID] [int] IDENTITY(1,1) PRIMARY KEY,
	[PurchaseDate] [datetime] NULL,
	[InvoiceNumber] [int] NULL,
	[QuantityBought] [int] NULL,
	[ProductID] [int] NULL,
	[DiscountID] [int] NULL,
	[PaymentID] [int] NULL,
	[VAT] [float] NULL,
	)


GO
