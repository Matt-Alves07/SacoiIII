/*Adicionado a ordena��o para listar as mais novas primeiro*/
USE sacoi;

DROP PROCEDURE IF EXISTS `VisualizarEmailUser`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `VisualizarEmailUser` (IN _usuario VARCHAR(25))
    READS SQL DATA
BEGIN
    /*Recebe o nome de usu�rio de usu�rio que est� listando os emails enviado e recebidos dele*/
    SELECT
        mensagem AS `ID`,
        user_remetente AS `Remetente`,
        COALESCE(assunto, 'SACOI') AS `Assunto`,
        texto AS `Conte�do`
    FROM
        sacoi.mensagens
    WHERE
        (user_destino = _usuario)
    ORDER BY
        criacao DESC;
END;