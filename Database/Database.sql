create database [Library] 
go

use [Library]
go

create table Books 
(
Title nvarchar(50) unique,
Author nvarchar(50) unique,
[Year] datetime2
)
go

create proc P_Insert_Book
@Title nvarchar(50),@Author nvarchar(50),@Year nvarchar(50)
as
begin
	insert into Books (Title,Author,[Year]) values (@Title,@Author,@Year)
end
go

create proc P_Update_Book
@Title nvarchar(50),@Author nvarchar(50),@Year nvarchar(50)
as
begin
	Update Books  set [Year] = @Year where Title = @Title and Author= @Author
end
go


create proc P_Delete_Book
@Title nvarchar(50),@Author nvarchar(50),@Year nvarchar(50)
as
begin
	delete from Books where Title=@Title and Author= @Author and [Year] = @Year
end
go