USE sacoi;

DROP PROCEDURE IF EXISTS `AtualizarNotificacao`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `AtualizarNotificacao`(IN p_user_name VARCHAR(25), IN p_notificacao VARCHAR(32), IN p_texto VARCHAR(255))
	MODIFIES SQL DATA
BEGIN
    IF ((SELECT COUNT(notificacao) FROM sacoi.notificacoes WHERE (notificacao = p_notificacao) AND (usuario = (SELECT usuario FROM sacoi.usuarios WHERE user_name = p_user_name))) > 0) THEN
        UPDATE sacoi.notificacoes SET texto = p_texto WHERE notificacao = p_notificacao;
        SELECT 'atualizou' AS `Resultado`;
    ELSE
        SELECT 'usuario_errado' AS `Resultado`;
    END IF;
END;