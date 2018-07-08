USE sacoi;

DROP PROCEDURE IF EXISTS `AlterarUsuario`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `AlterarUsuario`(IN _usuario VARCHAR(32), IN _p_nome VARCHAR(30), IN _s_nome VARCHAR(100), IN _email VARCHAR(100), IN _senha VARCHAR(20), IN _cargo VARCHAR(25))
	MODIFIES SQL DATA
BEGIN
    /*Atualiza o registro com os valores inseridos*/
	UPDATE sacoi.usuarios
	SET
		p_nome = _p_nome,
		s_nome = _s_nome,
		email = _email,
		senha = _senha,
		cargo = _cargo
	WHERE usuario = _usuario;

    /*Retorna a string 'sucesso' sinalizando que a mudança aconteceu como deveria*/
    SELECT 'sucesso' AS `Resultado`;
END;