USE sacoi;

DROP PROCEDURE IF EXISTS `AlterarNotificacao`;
DROP PROCEDURE IF EXISTS `AtualizarNotificacao`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `AlterarNotificacao`(IN _usuario VARCHAR(32), IN _notificacao VARCHAR(32), IN _texto VARCHAR(250)) MODIFIES SQL DATA
BEGIN
    /*Verifica se a notificação pertence ao usuário que está tentando excluí-la e se ela existe*/
    IF ((SELECT COUNT(*) FROM sacoi.notificacoes WHERE (notificacao = _notificacao)) > 0) THEN
        IF ((SELECT usuario FROM sacoi.notificacoes WHERE (notificacao = _notificacao)) = _usuario) THEN
            UPDATE sacoi.notificacoes SET texto = _texto, valido = 'true' WHERE (notificacao = _notificacao);
        
            /*Retorna a string sucesso como resultado da exclusão*/
            SELECT 'sucesso' AS `resultado`;
        ELSE
            IF ((SELECT admin FROM sacoi.usuarios WHERE (usuario = _usuario)) = 'true') THEN
                UPDATE sacoi.notificacoes SET texto = _texto, valido = 'true' WHERE (notificacao = _notificacao);

                /*Retorna a string sucesso como resultado da exclusão*/
                SELECT 'sucesso' AS `resultado`;
            ELSE
                /*Lança uma exceção com a mensagem informando que o usuário que está deletando não a criou a notificação ou que ele não é admin pra fazê-lo*/
                SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Esta mensagem não pertence ao usuário que efetuou login e ele não é um administrador para altera-la.';
            END IF;
        END IF;
    ELSE
        /*Lança uma exceção com a mensagem informando que a notificação já foi excluida*/
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Esta notificação não existe ou já foi excluida.';
    END IF;
END;