USE sacoi;

DROP PROCEDURE IF EXISTS `AdicionarUsuario`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `AdicionarUsuario`(IN _user_name VARCHAR(25), IN _p_nome VARCHAR(30), IN _s_nome VARCHAR(100), IN _email VARCHAR(100), IN _senha VARCHAR(20), IN _cargo VARCHAR(25))
	MODIFIES SQL DATA
BEGIN
	INSERT INTO sacoi.usuarios(usuario, user_name , p_nome, s_nome, email, senha, cargo)
    VALUES((MID(UUID(),1,32)), _user_name, _p_nome, _s_nome, _email, _senha, _cargo);
END;