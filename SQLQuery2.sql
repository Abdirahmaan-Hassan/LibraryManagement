create database LibraryManagementDB



create table loginTbl(
   id int identity(1,1) primary key,
   username varchar(60) not null,
   pass varchar(60) not null
)
select *from loginTbl
create table NewUser(
userID int primary key identity(1,1),

)

insert into loginTbl(username, pass) values('hassan','123');
insert into loginTbl(username, pass) values('shakra','abc');
select * from loginTbl


create table NewBook(
   Bid int identity(1,1) primary key,
   BName varchar(250) not null,
   BAuthor varchar(250) not null,
   BPubl  varchar(250) not null,
   BPDate varchar(250)  not null,
   BPrice bigint  not null,
   BQuant bigint  not null
)

create table NewStudent(
stuid int not null identity(1,1) primary key,
sname varchar(250) not null,
enroll varchar(250) not null,
dep varchar(250) not null,
sem varchar(250) not null,
contact bigint not null,
email varchar(250) not null
)
select *from NewStudent

create table IRBook(
id int not null identity(1,1) primary key,
std_enroll varchar(250) not null,
std_name varchar(250) not null,
std_dep varchar(250) not null,
std_sem varchar(250) not null,
std_contact bigint not null,
std_email varchar(250) not null,
book_name varchar(1250) not null,
book_issue_date varchar(250) not null,
book_return_date varchar(250)
)

select * from IRBook
insert into IRBook
values('C1201010','Hassan','IT','6',615839282,'hassan@gmail.com','HTML','2/15/2023','2/19/2023')


