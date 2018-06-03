USE sacoi;

DROP PROCEDURE IF EXISTS `PesquisarUsuarios`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `PesquisarUsuarios`(IN _user_name VARCHAR(20), IN _p_nome VARCHAR(25), IN _email VARCHAR(100))
	READS SQL DATA
BEGIN
	IF (_user_name != "") AND (_p_nome = "") AND (_email = "") THEN
		SELECT
			user_name AS `Nome de Usuário`,
			p_nome AS `Primeiro Nome`,
			s_nome AS `Sobrenome`,
			email AS `Email`,
			cargo AS `Cargo Ocupado`,
			CASE
				WHEN admin = 'true' THEN 'Sim'
				WHEN admin = 'false' THEN 'Não'
			END AS `Administrador`
		FROM
			sacoi.usuarios
		WHERE
			user_name LIKE CONCAT('%', _user_name, '%');
	ELSEIF (_user_name = "") AND (_p_nome != "") AND (_email = "") THEN
		SELECT
			user_name AS `Nome de Usuário`,
			p_nome AS `Primeiro Nome`,
			s_nome AS `Sobrenome`,
			email AS `Email`,
			cargo AS `Cargo Ocupado`,
			CASE
				WHEN admin = 'true' THEN 'Sim'
				WHEN admin = 'false' THEN 'Não'
			END AS `Administrador`
		FROM
			sacoi.usuarios
		WHERE
			p_nome LIKE CONCAT('%', _p_nome, '%');
	ELSEIF (_user_name = "") AND (_p_nome = "") AND (_email != "") THEN
		SELECT
			user_name AS `Nome de Usuário`,
			p_nome AS `Primeiro Nome`,
			s_nome AS `Sobrenome`,
			email AS `Email`,
			cargo AS `Cargo Ocupado`,
			CASE
				WHEN admin = 'true' THEN 'Sim'
				WHEN admin = 'false' THEN 'Não'
			END AS `Administrador`
		FROM
			sacoi.usuarios
		WHERE
			email LIKE CONCAT('%', _email, '%');
	ELSE
		SELECT
			user_name AS `Nome de Usuário`,
			p_nome AS `Primeiro Nome`,
			s_nome AS `Sobrenome`,
			email AS `Email`,
			cargo AS `Cargo Ocupado`,
			CASE
				WHEN admin = 'true' THEN 'Sim'
				WHEN admin = 'false' THEN 'Não'
			END AS `Administrador`
		FROM
			sacoi.usuarios;
	END IF;
END;