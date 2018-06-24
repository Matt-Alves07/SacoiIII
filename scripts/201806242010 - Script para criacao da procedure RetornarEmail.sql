USE sacoi;

DROP PROCEDURE IF EXISTS `RetornarEmail`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `RetornarEmail` (IN _mensagem VARCHAR(32))
    READS SQL DATA
BEGIN
    /*Recebe o identificador do email que o usu�rio/admin deseja visuzalizar*/
    SELECT
        user_remetente AS `Remetente`,
        assunto AS `Assunto`,
        texto AS `Conte�do`
    FROM
        sacoi.mensagens
    WHERE
        mensagem = _mensagem;
END;