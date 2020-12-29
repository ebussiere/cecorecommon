CREATE PROCEDURE [dbo].[spOrders_GetByID]
	@Id int = 0
	
AS
begin
set nocount on;
	SELECT [Id], [OrderName], [OrderDate], [FoodId], [Quantity], [Total] FROM dbo.[Order] 
	WHERE Id = @Id; 
end
