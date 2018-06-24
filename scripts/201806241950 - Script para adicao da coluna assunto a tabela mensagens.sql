/*Adiciona a coluna assunto a tabela mensagens antes da coluna texto*/
USE sacoi;

ALTER TABLE sacoi.mensagens ADD assunto VARCHAR(50) AFTER user_destino;