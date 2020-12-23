﻿CREATE PROCEDURE [dbo].[spOrders_Insert]
	@OrderName nvarchar(50),
	@OrderDate datetime2(7),
	@FoodId int,
	@Quantity int,
	@Total money,
	@Id int output
AS
begin
	set nocount on;
    INSERT INTO dbo.[Order](OrderName, OrderDate,FoodId,Quantity,Total)
	values (@OrderName, @OrderDate, @FoodId, @Quantity, @Total)
	set @Id = SCOPE_IDENTITY();
end

