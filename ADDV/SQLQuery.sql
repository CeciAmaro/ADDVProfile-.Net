create database Ataque
use Ataque


create table tblAuthor(AuthorId int PRIMARY KEY IDENTITY, AuthorName varchar(60));
create table tblDoctor(DoctorId int PRIMARY KEY IDENTITY, DoctorNumer int, DoctorName varchar(60), BirthDate date, FirstEpisodeDate date, LastEpisodeDate date);
create table tblEpisode(EpisodeIid int PRIMARY KEY IDENTITY, SeriesNumber int, EpisodeNumber int, EpisodeType varchar(50), Title varchar(60), EpisodeDate date, AuthorId int not null, FOREIGN KEY (AuthorId) REFERENCES tblAuthor(AuthorId), DoctorId int not null, FOREIGN KEY (DoctorId) REFERENCES tblDoctor(DoctorId), Notes varchar(100));


select * from tblAuthor
select * from tblDoctor
select * from tblEpisode



--e.2
select a.AuthorName, d.DoctorName, e.EpisodeNumber from tblAuthor a inner join tblEpisode e on a.AuthorId=e.AuthorId inner join tblDoctor d
on e.DoctorId = d.DoctorId;

--Queries jerárquicos
create table employee(employee_id int PRIMARY KEY IDENTITY, First_Name varchar(50), Last_Name varchar(60), manager_Id int null);
insert into employee(First_Name, Last_Name, manager_Id) values ('Rudolph', 'Roberts', 7);


select * from employee 
select employee_id, First_Name, manager_Id from employee order by employee_id desc
update employee set First_Name = 'Charles', Last_Name = 'Thomas' where employee_id = 9

-- Reporte de faltas
create table absence_type(absence_type_id int PRIMARY KEY IDENTITY(1,1), abs_type varchar(60));
insert into absence_type(abs_type) values('Horas extras');
select * from absence_type
create table ReporteFaltas(id int PRIMARY KEY IDENTITY(1,1), employee_id int, FOREIGN KEY (employee_id) REFERENCES employee(employee_id), absence_type_id int FOREIGN KEY (absence_type_id) REFERENCES absence_type(absence_type_id), num_of_hours int, absence_date date );
insert into ReporteFaltas(employee_id, absence_type_id, num_of_hours, absence_date) values(8,8,9, '2017-09-18');

select * from ReporteFaltas  

select employee_id, COUNT(absence_type_id) as Num_of_absence_type_2, sum(num_of_hours) as num_of_hours
from ReporteFaltas
where absence_type_id in(2, 3, 8)
group by employee_id, absence_type_id




