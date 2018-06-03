USE sacoi;

DROP PROCEDURE IF EXISTS `DeletarNotificacao`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletarNotificacao`(IN p_user_name VARCHAR(25), IN p_notificacao VARCHAR(32))
	MODIFIES SQL DATA
BEGIN
    IF ((SELECT COUNT(notificacao) FROM sacoi.notificacoes WHERE (notificacao = p_notificacao) AND (usuario = (SELECT usuario FROM sacoi.usuarios WHERE user_name = p_user_name))) > 0) THEN
        DELETE FROM sacoi.notificacoes WHERE notificacao = p_notificacao;
        SELECT 'apagou' AS `Resultado`;
    ELSE
        SELECT 'usuario_errado' AS `Resultado`;
    END IF;
END;