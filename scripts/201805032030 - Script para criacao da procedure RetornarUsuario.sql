USE sacoi;

DROP PROCEDURE IF EXISTS `RetornarUsuario`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetornarUsuario`(IN _user_name VARCHAR(25))
	READS SQL DATA
BEGIN
	SELECT
		usuario AS `Usu�rio`,
		user_name AS `Nome de Usu�rio`,
		p_nome AS `Nome`,
		s_nome AS `Sobrenome`,
		email AS `Email`,
		senha AS `Senha`,
		cargo AS `Cargo Ocupado`,
		CASE
			WHEN admin = 'true' THEN 'Sim'
			WHEN admin = 'false' THEN 'N�o'
		END AS `Administrador`
	FROM
		sacoi.usuarios
	WHERE
		user_name = _user_name;
END;