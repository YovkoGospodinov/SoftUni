UPDATE [dbo].[Payments]
 SET TaxRate = TaxRate - 0.03 * TaxRate

SELECT [TaxRate]
 FROM [dbo].[Payments]