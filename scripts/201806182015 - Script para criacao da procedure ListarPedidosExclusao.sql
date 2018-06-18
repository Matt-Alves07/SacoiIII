USE sacoi;

DROP PROCEDURE IF EXISTS `ListarPedidosExclusao`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `ListarPedidosExclusao` ()
    READS SQL DATA
BEGIN
    SELECT
        u.usuario AS `Usuário`,
        u.user_name AS `Nome de Usuário`,
        p.pedido AS `Pedido`,
        p.data_pedido AS `Data do pedido`
    FROM
        sacoi.pedidosmoderacao AS p
    LEFT JOIN
        sacoi.usuarios AS u ON p.usuario = u.usuario;
END;