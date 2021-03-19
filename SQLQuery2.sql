--Select
--ANSII
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers 

Select * from Customers where City = 'Berlin'

--case insensitive
Select *from Products where categoryId=1 or categoryId=3

Select *from Products where categoryId=1 and UnitPrice>=10

select * from Products order by UnitPrice asc	--ascending  default

select * from Products order by UnitPrice desc	--descending

Select count(*) Adet from Products where CategoryID=2

Select categoryID,COUNT(*) from Products where UnitPrice>20 Group by categoryID having count(*)<10

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null