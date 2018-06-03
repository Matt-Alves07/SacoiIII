USE sacoi;

DROP PROCEDURE IF EXISTS `ExibirNotificacoes`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ExibirNotificacoes`()
	READS SQL DATA
BEGIN
    SELECT
        u.user_name AS `Nome de Usuário`,
        n.texto AS `Conteudo`
    FROM
        sacoi.notificacoes n
    JOIN
        sacoi.usuarios u ON n.usuario = u.usuario
    WHERE 
        n.valido = 'true'
    ORDER BY
        n.criacao DESC
    LIMIT 10 ;
END;