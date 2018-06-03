/*
	Criação da tabela que armazena os pedidos de usuários para se tornarem administradores - Matheus Alves
*/

USE sacoi;

DROP TABLE IF EXISTS sacoi.pedidosmoderacao;
CREATE TABLE sacoi.pedidosmoderacao(
	pedido VARCHAR(32) NOT NULL PRIMARY KEY,
	usuario VARCHAR(32) NOT NULL,
	data_pedido TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);