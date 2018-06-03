USE sacoi;

DROP PROCEDURE IF EXISTS `PesquisarNotificacoes`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `PesquisarNotificacoes`(IN _user_name VARCHAR(20), IN _texto VARCHAR(255), IN _valido VARCHAR(5))
	READS SQL DATA
BEGIN
	IF (_user_name != "") AND (_texto = "") AND (_valido = "") THEN
		SELECT
            n.notificacao AS `ID`,
            n.texto AS `Conteudo`,
            u.usuario AS `ID Usuário`,
            u.user_name AS `Nome de usuário`,
            CASE
                WHEN n.valido = 'true' THEN "Sim"
                WHEN n.valido = 'false' THEN "Não"
            END AS `Valido`,
            n.criacao AS `Criado em`
        FROM
            sacoi.notificacoes n
        JOIN
            sacoi.usuarios u ON n.usuario = u.usuario
        WHERE
            n.usuario = (SELECT usuario FROM sacoi.usuarios WHERE user_name = _user_name)
        ORDER BY
            n.criacao DESC;
	ELSEIF (_user_name = "") AND (_texto != "") AND (_valido = "") THEN
		SELECT
            n.notificacao AS `ID`,
            n.texto AS `Conteudo`,
            u.usuario AS `ID Usuário`,
            u.user_name AS `Nome de usuário`,
            CASE
                WHEN n.valido = 'true' THEN "Sim"
                WHEN n.valido = 'false' THEN "Não"
            END AS `Valido`,
            n.criacao AS `Criado em`
        FROM
            sacoi.notificacoes n
        JOIN
            sacoi.usuarios u ON n.usuario = u.usuario
        WHERE
            n.texto LIKE CONCAT('%', _texto, '%')
        ORDER BY
            n.criacao DESC;
	ELSEIF (_user_name = "") AND (_texto = "") AND (_valido != "") THEN
		SELECT
            n.notificacao AS `ID`,
            n.texto AS `Conteudo`,
            u.usuario AS `ID Usuário`,
            u.user_name AS `Nome de usuário`,
            CASE
                WHEN n.valido = 'true' THEN "Sim"
                WHEN n.valido = 'false' THEN "Não"
            END AS `Valido`,
            n.criacao AS `Criado em`
        FROM
            sacoi.notificacoes n
        JOIN
            sacoi.usuarios u ON n.usuario = u.usuario
        WHERE
            n.valido = _valido
        ORDER BY
            n.criacao DESC;
	ELSE
		SELECT
            n.notificacao AS `ID`,
            n.texto AS `Conteudo`,
            u.usuario AS `ID Usuário`,
            u.user_name AS `Nome de usuário`,
            CASE
                WHEN n.valido = 'true' THEN "Sim"
                WHEN n.valido = 'false' THEN "Não"
            END AS `Valido`,
            n.criacao AS `Criado em`
        FROM
            sacoi.notificacoes n
        JOIN
            sacoi.usuarios u ON n.usuario = u.usuario
        ORDER BY
            n.criacao DESC;
	END IF;
END;