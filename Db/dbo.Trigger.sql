create procedure [dbo].[strlogin]  
(  
   @username varchar(40),  
   @email varchar(50),  
   @password varchar(20)  
)  
as  
insert into registration values(@username,@email,@password )