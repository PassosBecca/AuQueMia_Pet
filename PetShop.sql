create database petshop

use database petshop

create table tutor
(
cpf varchar(11) not null,
nome varchar(100) not null,
endereco varchar(100),
telefone varchar(15) not null,
primary key (cpf)
)

create table pet
(
idPet int auto_increment not null,
cpf_tutor varchar(11) not null,
nome_pet varchar(100) not null,
especie varchar(50) not null,
sexo varchar(15) not null,
porte varchar(10) not null,
primary key (idPet),
foreign key (cpf_tutor) references tutor (cpf)
)


create table funcionario
(
idFuncionario int auto_increment  not null,
nome varchar(100) not null,
cpf varchar (11) not null,
telefone varchar(15) not null,
funcao varchar (50),
primary key (idFuncionario)
)



create table agendamento
(
cpf_tutor varchar(11) not null,
idPet int not null,
idAgendamento int auto_increment not null,
banho varchar(15) not null,
tosa varchar (15) not null,
semana varchar (20) not null,
horario datetime not null,
primary key (idAgendamento),
foreign key (idPet) references pet (idPet),
foreign key (cpf_tutor) references pet (cpf_tutor)
)





select*
from funcionario

select*
from tutor

select *
from agendamento

select*
from pet


INSERT into funcionario (idFuncionario, nome, cpf, telefone, funcao)
VALUES (1, 'Rebeca', 12345678922, 998526685, 'Banhista')

INSERT INTO tutor (cpf, nome , endereco, telefone)
VALUES (12345678923, 'Maria', 'Rua Florença, Bairro Terra, Número 544')

insert into tutor (cpf, nome, endereco, telefone)
values(12345678933, 'Tamires', 'Rua Marte, Bairro Artemos,  Número 255')

INSERT INTO pet (cpf_tutor, nome_tutor, idPet, nome_pet, especie, sexo, porte)
values (12345678923, 'Maria', 1, 'Laio', 'Canina', 'Masculino', 'Pequeno')



SELECT * FROM agendamento, tutor, pet where pet.cpf_tutor=tutor.cpf and agendamento.idPet=pet.idPet order by nome_pet




