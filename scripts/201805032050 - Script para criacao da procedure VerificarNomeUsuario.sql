USE sacoi;

DROP PROCEDURE IF EXISTS `VerificarNomeUsuario`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `VerificarNomeUsuario` (IN _user_name VARCHAR(25))
	READS SQL DATA
BEGIN
	IF EXISTS (SELECT * FROM sacoi.usuarios WHERE user_name = _user_name) THEN
		SELECT 'usado';
	ELSE
		SELECT 'livre';
	END IF;
END;