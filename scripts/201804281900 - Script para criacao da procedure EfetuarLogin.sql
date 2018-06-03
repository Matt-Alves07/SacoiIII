USE sacoi;

DROP PROCEDURE IF EXISTS `EfetuarLogin`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `EfetuarLogin`(IN _user_name VARCHAR(25), IN _senha VARCHAR(20))
	READS SQL DATA
BEGIN
	IF ((SELECT COUNT(*) FROM sacoi.usuarios WHERE user_name = _user_name AND senha = _senha) > 0) THEN
		IF ((SELECT admin FROM sacoi.usuarios WHERE user_name = _user_name AND senha = _senha) = 'true') THEN
			SELECT
				'true' AS `Existe`,
				'true' AS `Admin`;
		ELSEIF ((SELECT admin FROM sacoi.usuarios WHERE user_name = _user_name AND senha = _senha) = 'false') THEN
			SELECT
				'true' AS `Existe`,
				'false' AS `Admin`;
		END IF;
	ELSE
		SELECT
			'false' AS `Existe`,
			'false' AS `Admin`;
	END IF;
END;