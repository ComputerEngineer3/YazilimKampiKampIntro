--Select * from Customers c left join Orders o
--on c.CustomerID = o.CustomerID
--where o.CustomerID is null

select * from Products
select * from Orders
select * from [Order Details]

Select ProductName 'Ürün Adı', SUM([Order Details].UnitPrice*[Order Details].Quantity) 'Kazanılan Toplam Miktar' 
from ((Products inner join [Order Details]
on Products.ProductID = [Order Details].ProductID) inner join Orders
on [Order Details].OrderID = Orders.OrderID)
group by ProductName;