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