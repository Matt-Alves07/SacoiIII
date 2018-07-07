USE sacoi;

DROP PROCEDURE IF EXISTS `InvalidarNotificacao`;

DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `InvalidarNotificacao`(IN _usuario VARCHAR(32), IN _notificacao VARCHAR(32)) MODIFIES SQL DATA
BEGIN
    /*Verifica se a notifica��o pertence ao usu�rio que est� tentando exclu�-la e se ela existe*/
    IF ((SELECT COUNT(*) FROM sacoi.notificacoes WHERE (notificacao = _notificacao)) > 0) THEN
        IF ((SELECT usuario FROM sacoi.notificacoes WHERE (notificacao = _notificacao)) = _usuario) THEN
            UPDATE sacoi.notificacoes SET valido = 'false' WHERE (notificacao = _notificacao);
        
            /*Retorna a string sucesso como resultado da exclus�o*/
            SELECT 'sucesso' AS `resultado`;
        ELSE
            IF ((SELECT admin FROM sacoi.usuarios WHERE (usuario = _usuario)) = 'true') THEN
                UPDATE sacoi.notificacoes SET valido = 'false' WHERE (notificacao = _notificacao);

                /*Retorna a string sucesso como resultado da exclus�o*/
                SELECT 'sucesso' AS `resultado`;
            ELSE
                /*Lan�a uma exce��o com a mensagem informando que o usu�rio que est� deletando n�o a criou a notifica��o ou que ele n�o � admin pra faz�-lo*/
                SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Esta mensagem n�o pertence ao usu�rio que efetuou login e ele n�o � um administrador para exclu�-la.';
            END IF;
        END IF;
    ELSE
        /*Lan�a uma exce��o com a mensagem informando que a notifica��o j� foi excluida*/
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Esta notifica��o n�o existe ou j� foi excluida.';
    END IF;
END;