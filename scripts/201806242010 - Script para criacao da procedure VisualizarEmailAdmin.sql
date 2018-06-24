USE sacoi;

DROP PROCEDURE IF EXISTS `VisualizarEmailAdmin`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `VisualizarEmailAdmin` (IN _usuario VARCHAR(25))
    READS SQL DATA
BEGIN
    /*Recebe o nome de usu�rio de usu�rio que est� listando os emails enviado e recebidos dele*/
    SELECT
        mensagem AS `ID`,
        user_remetente AS `Remetente`,
        assunto AS `Assunto`,
        texto AS `Conte�do`
    FROM
        sacoi.mensagens
    WHERE
        (user_destino = _usuario)
    OR
        (user_remetente = _usuario);
END;