use[Connection];


create table Traveller(FirstName varchar(20),LastName varchar(20),Age Numeric(3),SetPassword varchar(20),ConfirmPassword varchar(20),Gender varchar(7),Email varchar(30) primary key,LocationAddress varchar(30),City varchar(10),Pincode varchar(10))
select * from Traveller;



Create Procedure sp_RegisterationDetails
@FirstName varchar(20),
@LastName varchar(20),
@Age numeric(20),
@SetPassword varchar(20),
@ConfirmPassword varchar(20),
@Gender varchar(10),
@Email varchar(20),
@LocationAddress varchar(20),
@City varchar(10),
@Pincode varchar(10)
as
begin
Insert into Traveller(FirstName,LastName,Age,SetPassword,ConfirmPassword,Gender,Email,LocationAddress,City,Pincode)
Values(@FirstName,@LastName,@Age,@SetPassword,@ConfirmPassword,@Gender,@Email,@LocationAddress,@City,@Pincode);
end	

