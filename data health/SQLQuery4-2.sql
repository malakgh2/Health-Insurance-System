create database climentB
use climentB
create table employee
( matricule int constraint  pk_matricule primary key,
cin int constraint icin unique,
nom varchar(30),
prenom varchar(30),
adresse varchar(30),
etatc varchar(30),
grade int,
nomcon varchar(30),
prenomcon varchar(30),
numtel int ,
ccname int constraint uk_ccname unique,
nbrenfant int,
datenais date,
solde float);

create table bulletin
(numéro int constraint  pk_num primary key,
acte varchar(50),
date_Depot date,
frais float,
employé int constraint fk_id  references employee(matricule) on delete cascade ,
reste float
);
create table admin1
(
password1 varchar(30),
ID varchar(30) constraint AdminID primary key,
login2 varchar(30) constraint ch_login check(login2 like'%_@_%._%')
);
create table agentsocial
(ID int constraint  agentID primary key,
password1 varchar(30),
login1 varchar(30) constraint loginag unique,
);
insert into employee values(104,2003,'bala','karim','wardia','celibataire',1,'','',27213124,1004,0,'2022-1-2',1800)
insert into bulletin values(2,'grippe','2024-3-23',30,104,0);
select * from bulletin
select * from employee
create table rapport(
num_demande int ,
rapport_Ligne varchar(20),
matricule int ,
date_Depot date ,
reste float
)

