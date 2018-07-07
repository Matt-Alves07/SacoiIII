USE sacoi;

DROP PROCEDURE IF EXISTS `ListarNotificacoesWithInvalidas`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListarNotificacoesWithInvalidas`()
	READS SQL DATA
BEGIN
    SELECT
        n.notificacao AS `ID`,
        n.texto AS `Conteudo`,
        u.usuario AS `ID Usu�rio`,
        u.user_name AS `Nome de Usu�rio`,        
        CASE
            WHEN n.valido = 'true' THEN "Sim"
            WHEN n.valido = 'false' THEN "N�o"
        END AS `Valido`
    FROM
        sacoi.notificacoes n
    JOIN
        sacoi.usuarios u ON n.usuario = u.usuario
    ORDER BY
        n.criacao DESC;
END;