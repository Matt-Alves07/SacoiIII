USE sacoi;

DROP PROCEDURE IF EXISTS `RejeitarAdmin`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `RejeitarAdmin` (IN _usuario VARCHAR(32))
    MODIFIES SQL DATA
BEGIN
    /*Deleta o pedido para que o mesmo não apareça mais ao relistar os pedidos*/
    DELETE FROM sacoi.pedidosmoderacao WHERE usuario = _usuario;

    /*Retorna uma string informando que a alteração foi feita com sucesso*/
    SELECT 'sucesso' AS `Resultado`;
END;