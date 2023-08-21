create database BD;

use BD;

create table Login(
  Codigo int primary key auto_increment,
  Usuario varchar(60),
  Senha   varchar (20)
);

insert into Login (Usuario, Senha) values ("ADMIN", "1234567");

