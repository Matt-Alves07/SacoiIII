USE sacoi;

DROP PROCEDURE IF EXISTS `DeletarUsuario`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletarUsuario`(IN _usuario VARCHAR(32))
	MODIFIES SQL DATA
BEGIN
    /*Apaga o pedido que havia sido feito, n�o o exibindo novamente quando a lista de pedidos for atualizada*/
	DELETE FROM sacoi.pedidoexclusao WHERE usuario = _usuario;
    /*Apaga o registro do usu�rio em usu�rios*/
	DELETE FROM sacoi.usuarios WHERE usuario = _usuario;

    /*Retorna uma string caso tudo ocorra bem*/
    SELECT 'sucesso' AS `Resultado`;
END;