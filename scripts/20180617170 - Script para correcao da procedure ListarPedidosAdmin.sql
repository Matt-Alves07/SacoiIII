USE sacoi;

DROP PROCEDURE IF EXISTS `ListarPedidosAdmin`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `ListarPedidosAdmin` ()
    READS SQL DATA
BEGIN
    SELECT
        u.usuario AS `Usuário`,
        p.pedido AS `Pedido`,
        u.user_name AS `Nome de Usuário`,
        p.data_pedido AS `Data do pedido`
    FROM
        sacoi.pedidosmoderacao AS p
    LEFT JOIN
        sacoi.usuarios AS u ON p.usuario = u.usuario
    ORDER BY
        p.data_pedido;
END;