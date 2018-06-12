USE sacoi;

DROP PROCEDURE IF EXISTS `ListarPedidosAdmin`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `ListarPedidosAdmin` ()
    READS SQL DATA
BEGIN
    SELECT
        u.user_name AS `Usuário`,
        p.data_pedido AS `Data do pedido`
    FROM
        sacoi.pedidosmoderacao AS p
    LEFT JOIN
        sacoi.usuarios AS u ON p.usuario = u.usuario;
END;