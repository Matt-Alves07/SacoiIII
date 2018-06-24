USE sacoi;

DROP PROCEDURE IF EXISTS `VisualizarEmailUser`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `VisualizarEmailUser` (IN _usuario VARCHAR(25))
    READS SQL DATA
BEGIN
    /*Recebe o nome de usuário de usuário que está listando os emails recebidos dele*/
    SELECT
        mensagem AS `ID`,
        user_remetente AS `Remetente`,
        assunto AS `Assunto`,
        texto AS `Conteúdo`
    FROM
        sacoi.mensagens
    WHERE
        user_destino = _usuario;
END;