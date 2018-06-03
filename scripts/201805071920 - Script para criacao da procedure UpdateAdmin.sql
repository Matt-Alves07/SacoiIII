USE sacoi;

DROP PROCEDURE IF EXISTS `Updateadmin`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `UpdateAdmin` (IN _usuario VARCHAR(32))
    READS SQL DATA
BEGIN
    UPDATE sacoi.usuarios SET admin = 'true' WHERE usuario = _usuario;
END;