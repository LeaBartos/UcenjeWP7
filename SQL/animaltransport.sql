use master;
go

drop database if exists animaltransport;
go
create database animaltransport collate Croatian_CI_AS;
go

use animaltransport;
go

create table prijevozi (
sifra int not null primary key identity(1,1),
vrsta varchar (30) not null,
polaziste varchar (70) not null,
odrediste varchar (70) not null,
datum date not null,
vrsta_zivotinje varchar (50) not null,
kolicina int not null,
nacin_placanja varchar (50) not null,
narucitelj varchar (70) not null,
prijevoznik varchar (70) not null
);

create table narucitelji (
sifra int not null primary key identity(1,1),
vrsta varchar (30) not null,
ime varchar (50) not null,
prezime varchar(50) not null,
adresa varchar (50) not null,
telefon varchar (15) not null,
e-mail varchar (100) not null,
);

create table prijevoznici (
sifra int not null primary key identity(1,1),
naziv varchar (50) not null,
oib char (11) null,
broj_licence varchar (20) not null,
adresa varchar (50) not null,
telefon varchar (15) not null,
e-mail varchar (100) not null,
);

--1
insert into prijevozi ( vrsta, polaziste, odrediste, datum, 
vrsta_zivotinje, kolicina, nacin_placanja, 
narucitelj, prijevoznik ) values

( 'Automobil', 'Osijek', 'Zagreb', '2024-11-12', 
'Pas', '2', 'Gotovina', 'Lea_Bartos', 
'Monaline_Professional_Transport');

--2
insert into prijevozi ( vrsta, polaziste, odrediste, datum, 
vrsta_zivotinje, kolicina, nacin_placanja, 
narucitelj, prijevoznik ) values

( 'Kombi', 'Osijek', 'Rijeka', '2024-12-12', 
'Macka', '3', 'Karticno_placanje', 'Gordana_Grnja', 
'Demian_Transport');

--3
insert into prijevozi ( vrsta, polaziste, odrediste, datum, 
vrsta_zivotinje, kolicina, nacin_placanja, 
narucitelj, prijevoznik ) values

( 'Kamion', 'Osijek', 'Split', '2024-13-12', 
'Konj', '5', 'Placanje_putem_e-racuna', 'Pijunovic Company', 
'Horse_Transport');

--4
insert into narucitelji ( vrsta, ime, prezime, adresa, 
telefon, e-mail ) values

( 'Fizicka_osoba', '1', '1', 'Osijek', '098765432', 'leabartos@gmail.com');

--5
insert into narucitelji ( vrsta, ime, prezime, adresa, 
telefon, e-mail ) values
( 'Fizicka_osoba', '2', '2', 'Osijek', '0915664432', 'gordanagrnja@gmail.com');

--6
insert into narucitelji ( vrsta, ime, prezime, adresa, 
telefon, e-mail ) values
( 'Pravna osoba', '3', '3', 'Osijek', '0989701878', 'pijunovic@gmail.com');

--7
insert into prijevoznici ( naziv, oib, broj_licence, adresa, 
telefon, e-mail ) values

( '1', '16092240758', 'HR10032100', 'Sjenjak_28', '031573482', 'mpro@gmail.com');

--8
insert into prijevoznici ( naziv, oib, broj_licence, adresa, 
telefon, e-mail ) values

( '2', '76545578987', 'HR10032110', 'Ruzina_32', '031456654', 'demian@gmail.com');

--9
insert into prijevoznici ( naziv, oib, broj_licence, adresa, 
telefon, e-mail ) values

( '3', '23445543123', 'HR10032132', 'Cvjetkova_110', '031100987', 'horse@gmail.com');
