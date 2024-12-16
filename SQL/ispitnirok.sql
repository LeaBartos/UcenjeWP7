use master;
go
drop database if exist ispitnirok;
go
create database ispitnirok;
go

use ispitnirok;

create table ispitnirok(
sifra int,
predmet varchar (50),
vrsta ispita varchar (10),
datum datetime,
pristupio bit
);

create table pristupnici (
ispitnirok varchar,
student varchar,
brojbodova char,
ocjena varchar
);


