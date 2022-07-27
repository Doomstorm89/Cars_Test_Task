# Cars_Test_Task
Тестовое задание: написать класс автомобиля и реализовать требуемую логику

SQL-запрос:
Ссылка на тестовую БД: https://dbfiddle.uk/?rdbms=sqlserver_2019&fiddle=4f4a4aabad57aa57bb89821a8effafe8
---
--Создание таблиц и заполнение значений
create table Customers
(
Id int not null unique,
Name varchar(255)
);
insert into Customers(Id, Name)
values(1, 'Max'), (2, 'Pavel'), (3, 'Ivan'), (4, 'Leonid');

create table Orders
(
Id int not null unique,
CustomerId int null
);
insert into Orders(Id, CustomerId)
values(1, 2), (2, 4);
_____
--Имена всех покупателей не совершивших ни одной покупки 
select Name from Customers
where Id not in (select CustomerId from Orders)
