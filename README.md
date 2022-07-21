# FigureArea

SELECT p.Name as "Продукт", c.Name as "Категория"
FROM [Products] AS p
LEFT JOIN [ProductCategories] as t ON p.Id=t.ProductId
LEFT JOIN [Categories] as c ON c.Id = t.CategoryId
