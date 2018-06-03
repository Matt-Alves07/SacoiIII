/*
	Cria��o da tabela que lista os pedidos de exclus�es - Matheus Alves
*/

USE sacoi;

DROP TABLE IF EXISTS sacoi.ListaExclusao;
DROP TABLE IF EXISTS sacoi.pedidoexclusao;
CREATE TABLE sacoi.pedidoexclusao(
	pedido VARCHAR(32) NOT NULL PRIMARY KEY,
	usuario VARCHAR(32) NOT NULL,
	data_pedido TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);