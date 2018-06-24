USE sacoi;

DROP PROCEDURE IF EXISTS `AdicionarEmail`;

DELIMITER //
CREATE DEFINER = `root`@`localhost` PROCEDURE `AdicionarEmail` (IN _user_sender VARCHAR(25), IN _user_receiver VARCHAR(25), IN _assunto VARCHAR(50), IN _texto VARCHAR(255))
    MODIFIES SQL DATA
BEGIN
    /*Recebe o nome de usuário de usuário ao qual o emai se destina e o nome de usuário do admin que está enviando o email, junto com o texto*/
    INSERT INTO sacoi.mensagens(mensagem, user_remetente, user_destino, assunto, texto)
    VALUES((MID(UUID(),1,32)), _user_sender, _user_receiver, _assunto, _texto);

    SELECT 'sucesso';
END;