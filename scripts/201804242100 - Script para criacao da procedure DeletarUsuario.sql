USE sacoi;

DROP PROCEDURE IF EXISTS `DeletarUsuario`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletarUsuario`(IN _usuario VARCHAR(32))
	MODIFIES SQL DATA
BEGIN
	DELETE FROM sacoi.pedidosexclusao WHERE usuario = _usuario;
	DELETE FROM sacoi.usuarios WHERE usuario = _usuario;
END;