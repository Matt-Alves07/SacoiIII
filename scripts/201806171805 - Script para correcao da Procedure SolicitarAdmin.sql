USE sacoi;

DROP PROCEDURE IF EXISTS `SolicitarAdmin`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `SolicitarAdmin` (IN _usuario VARCHAR(25))
    MODIFIES SQL DATA
BEGIN
    /*Variavel de controle para exce��o de duplicar a chave prim�ria, ou mesmo usu�rio solicitar duas vezes*/
    DECLARE EXIT HANDLER FOR SQLSTATE '23000' SELECT 'solicitado';

    /*Verifica se j� existe um pedido feito por esse usu�rio*/
    IF (SELECT COUNT(usuario) FROM sacoi.pedidosmoderacao WHERE usuario = (SELECT usuario FROM sacoi.usuarios WHERE user_name = _usuario)) > 0 THEN
        /*Se existir dispara uma exce��o para sinalizar que o pedido j� foi feito*/
        BEGIN
			SIGNAL SQLSTATE VALUE '23000'
			SET MESSAGE_TEXT = 'solicitado';
		END;
    ELSE
        /*Se n�o existir, insere o pedido na respectiva tabela e retorna uma string de confirma��o*/
        INSERT INTO sacoi.pedidosmoderacao(pedido, usuario)
        VALUES((MID(UUID(),1,32)), (SELECT usuario FROM sacoi.usuarios WHERE user_name = _usuario));

        SELECT 'sucesso';
    END IF;
END;