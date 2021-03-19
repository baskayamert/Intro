Select p.ProductName UrunAdi, SUM(od.UnitPrice * od.Quantity) KazanilanToplamMiktar
From (Products p inner join [Order Details] od on p.ProductID = od.ProductID)
inner join Orders o on od.OrderID = o.OrderID
Group by p.ProductName
Order by p.ProductName asc
