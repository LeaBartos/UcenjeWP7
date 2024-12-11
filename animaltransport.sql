use master;
go
drop database if exists animal;
go
create database animal collate Croatian_CI_AS;
go
use animal;
go

create table prijevoz (
sifra int not null primary key identity(1,1),
vrsta varchar (30) not null,
polaziste varchar (70) not null,
odrediste varchar(70) not null,
datum date not null,
vrsta_zivotinje varchar (50) not null,
kolicina int not null,
nacin_placanja varchar (50) not null,
narucitelj varchar (70) not null,
prijevoznik varchar (70) not null

);

create table narucitelj (
sifra int not null primary key identity(1,1),
vrsta varchar (30) not null,
ime varchar (50) not null,
prezime varchar(50) not null,
adresa varchar (50) not null,
telefon varchar (15) not null,
e-mail varchar (100) not null,

);

create table prijevoznik (
sifra int not null primary key identity(1,1),
naziv varchar (50) not null,
oib char (11) null,
broj_licence varchar (20) not null,
adresa varchar (50) not null,
telefon varchar (15) not null,
e-mail varchar (100) not null,

);
--1

insert into prijevoz ( vrsta, polaziste, odrediste, datum, 
vrsta_zivotinje, kolicina, nacin_placanja, 
narucitelj, prijevoznik ) values
( 'Automobil', 'Osijek', 'Zagreb', '2024-11-12', 
'Pas', '2', 'gotovina', 'Lea Bartos', 
'Monaline Professional');

insert into narucitelj ( vrsta, ime, prezime, adresa, 
telefon, e-mail ) values
( 'Fizicka_osoba', 'Lea', 'Bartos', 'Osijek', '098765432', 'leabartos@gmail.com');



insert into prijevoznik ( naziv, oib, broj_licence, adresa, 
telefon, e-mail ) values



('Monaline_Professional', '123456789123', 'HR12345678', 'Kralja_Tomislava_7',
'monaline@gmail.com');
