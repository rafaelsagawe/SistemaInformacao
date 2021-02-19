# Banco de dados

CREATE database gestaoInformacao;

use gestaoInformacao;

CREATE table if not exists usuarios(
id_user INTEGER primary key auto_increment not null,
nome_compelto varchar(50) not null,
user_name varchar(150) not null,
fone varchar (15) not null,
email varchar(50)
);


INSERT  into usuarios (nome_compelto, user_name, fone, email)
values 
('Alpha', 'alpha', '123', 'alpha@sa.com'),
('Betha', 'betha', '456', 'betha@sa.com'),
('Sigma', 'sigma', '789', 'sigma@sa.com');


##DROP table usuarios;

SELECT *
FROM usuarios
where id_user LIKE 1;


## Não retornar null na consulta
SELECT        IFNULL(nome_compelto, 0) AS nome_compelto
FROM            usuarios
WHERE        (user_name LIKE @Param1)


CREATE table unidade(
id_unidade int primary key auto_increment, 
nome varchar(200) not null,
nome_comum varchar(50),
num_proto int(3),
inep int, 
cnpj int);


CREATE TABLE gestaoInformacao.alunosAnosTarde (
	alunosAnos INT null ,
	id_unidade INT NULL,
	inf4 int(3) NULL,
	inf5 int(3) NULL,
	ano1 int(3) NULL,
	ano2 int(3) NULL,
	ano3 int(3) NULL,
	ano4 int(3) NULL,
	ano5 int(3) NULL,
	ano6 int(3) NULL,
	ano7 int(3) NULL,
	ano8 int(3) NULL,
	ano9 int(3) NULL
);

CREATE TABLE gestaoInformacao.frequencia (
	id_FreqServidor INT auto_increment primary key,
	id_unidade varchar(100) NOT NULL COMMENT 'Chave extrangeira da tabela unidade - ok',
	pref_mat INT NOT NULL,
	matricula INT NOT NULL,
	nome_servidor varchar(500) NOT NULL,
	id_regime varchar(100) NULL COMMENT 'Chave extrangeira da tabela regime - ok',
	id_cargo varchar(100) NULL COMMENT 'Chave extrangeira da tabela cargo - ok',
	turno VARCHAR(30) NULL,
	id_turma_regente INT(2) NULL COMMENT 'Chave extrangeira da tabela turma - ok',
	id_funcao INT(2) NULL COMMENT 'Chave extrangeira da tabela funcao - ok',
	id_siglaRH INT(2) NULL COMMENT 'Chave extrangeira da tabela Siglas do RH',
	codigos VARCHAR(3) NULL,
	faltas INT(3) NULL,
	obs varchar(500) NULL
);