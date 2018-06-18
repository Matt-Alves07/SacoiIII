USE sacoi;

DROP PROCEDURE IF EXISTS `AprovarAdmin`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `AprovarAdmin` (IN _usuario VARCHAR(32))
    MODIFIES SQL DATA
BEGIN
    /*Deleta o pedido para que o mesmo não apareça mais ao relistar os pedidos*/
    DELETE FROM sacoi.pedidosmoderacao WHERE usuario = _usuario;

    /*Atualiza o registro em usuarios para que ao efetuar login novamente o mesmo seja direcionado para a tela home de admins*/
    UPDATE sacoi.usuarios SET admin = 'true' WHERE usuario = _usuario;

    /*Retorna uma string informando que a alteração foi feita com sucesso*/
    SELECT 'sucesso' AS `Resultado`;
END;