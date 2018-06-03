USE sacoi;

/*Foi necessário refazer a tabela de notificações por causa do tamanho do campo usuario que constava nela*/
DROP TABLE IF EXISTS sacoi.noticacao;
DROP TABLE IF EXISTS sacoi.notificacoes;
CREATE TABLE sacoi.notificacoes(
	notificacao VARCHAR(32) NOT NULL PRIMARY KEY,
	usuario VARCHAR(32) NOT NULL,
	texto TINYTEXT NOT NULL,
	valido VARCHAR(5) NOT NULL DEFAULT 'true',
	criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP()
);

DROP PROCEDURE IF EXISTS `AdicionarNotificacao`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `AdicionarNotificacao`(IN p_user_name VARCHAR(25), IN p_texto VARCHAR(255))
	MODIFIES SQL DATA
BEGIN
    INSERT INTO sacoi.notificacoes(notificacao, usuario, texto)
    VALUES((MID(UUID(),1,32)), (SELECT usuario FROM sacoi.usuarios WHERE user_name = p_user_name), p_texto);
END;