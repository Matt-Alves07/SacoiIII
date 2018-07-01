USE sacoi;

DROP PROCEDURE IF EXISTS `ApagarPedidoExclusao`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ApagarPedidoExclusao`(IN _usuario VARCHAR(32))
	MODIFIES SQL DATA
BEGIN
    /*Apaga o pedido que constava na tabela de pedidos de exclusão*/
	DELETE FROM sacoi.pedidoexclusao WHERE usuario = _usuario;

    /*Retorna uma string como resultado se tudo ocorrer bem*/
    SELECT 'sucesso' AS `Resultado`;
END;