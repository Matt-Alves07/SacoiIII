USE sacoi;

DROP PROCEDURE IF EXISTS `VisualizarEmailAdmin`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `VisualizarEmailAdmin` (IN _usuario VARCHAR(25))
    READS SQL DATA
BEGIN
    /*Recebe o nome de usuário de usuário que está listando os emails enviado e recebidos dele*/
    SELECT
        mensagem AS `ID`,
        user_remetente AS `Remetente`,
        assunto AS `Assunto`,
        texto AS `Conteúdo`
    FROM
        sacoi.mensagens
    WHERE
        (user_destino = _usuario)
    OR
        (user_remetente = _usuario);
END;