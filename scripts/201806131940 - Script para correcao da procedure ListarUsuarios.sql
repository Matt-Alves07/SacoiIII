USE sacoi;

DROP PROCEDURE IF EXISTS `ListarUsuarios`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListarUsuarios` ()
	READS SQL DATA
BEGIN
	SELECT
        usuario AS `Usuário`,
		user_name AS `Nome de Usuário`,
		p_nome AS `Primeiro Nome`,
		s_nome AS `Sobrenome`,
		email AS `Email`,
		cargo AS `Cargo Ocupado`,
		CASE
			WHEN admin = 'true' THEN 'Sim'
			WHEN admin = 'false' THEN 'Não'
		END AS `Administrador`
	FROM sacoi.usuarios;
END;