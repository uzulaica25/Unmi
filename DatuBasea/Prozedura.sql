DELIMITER //

CREATE PROCEDURE gailu_zaharrenak()
BEGIN
    SELECT *
    FROM Gailuak
    ORDER BY erostedata ASC
    LIMIT 10;
END //

DELIMITER ;