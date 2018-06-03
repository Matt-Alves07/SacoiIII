/*
	Criação do banco de dados e das tabelas basicas necessarias para o devido funcionamento - Matheus Alves
*/

DROP DATABASE IF EXISTS sacoi;
CREATE DATABASE IF NOT EXISTS sacoi;

USE sacoi;

DROP TABLE IF EXISTS sacoi.usuario;
DROP TABLE IF EXISTS sacoi.usuarios;
CREATE TABLE sacoi.usuarios(
	usuario VARCHAR(32) NOT NULL PRIMARY KEY,
	user_name VARCHAR(25) NOT NULL,
	p_nome VARCHAR(30),
	s_nome VARCHAR(100),
	email VARCHAR(100) NOT NULL,
	senha VARCHAR(20) NOT NULL,
	cargo VARCHAR(25),
	admin VARCHAR(5) NOT NULL DEFAULT 'false',
	criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP(),
	UNIQUE(user_name)
);

DROP TABLE IF EXISTS sacoi.mensagem;
DROP TABLE IF EXISTS sacoi.mensagens;
CREATE TABLE sacoi.mensagens(
	mensagem VARCHAR(32) NOT NULL PRIMARY KEY,
	user_remetente VARCHAR(25) NOT NULL,
	user_destino VARCHAR(25) NOT NULL,
	texto TEXT NOT NULL,
	criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

DROP TABLE IF EXISTS sacoi.noticacao;
DROP TABLE IF EXISTS sacoi.notificacoes;
CREATE TABLE sacoi.notificacoes(
	notificacao VARCHAR(32) NOT NULL PRIMARY KEY,
	usuario VARCHAR(25) NOT NULL,
	texto TINYTEXT NOT NULL,
	valido VARCHAR(5) NOT NULL DEFAULT 'true',
	criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

/*
Exemplo de insercao usando o gerador de id:
INSERT INTO sacoi.usuarios(usuario, user_name, p_nome, s_nome, email, senha, cargo)
VALUES(md5(id), 'MASTER', 'ADMIN', 'GERAL', 'teste.cadastro@teste.com', '999999', 'Administrador Geral'); 
*/