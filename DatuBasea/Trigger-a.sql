DELIMITER //

CREATE TRIGGER trg_gailua_ezabatu
BEFORE DELETE ON Gailuak
FOR EACH ROW
BEGIN

    -- Guardar en tabla general
    INSERT INTO Ezabatuak (ID, marka, kokalekua, erostedata, IDMintegia)
    VALUES (OLD.ID, OLD.marka, OLD.kokalekua, OLD.erostedata, OLD.IDMintegia);

    -- Si es ordenador
    IF EXISTS (SELECT 1 FROM Ordenagailuak WHERE ID = OLD.ID) THEN
        
        INSERT INTO Ezabatutako_ordenagailuak (ID, CPU, RAM)
        SELECT ID, CPU, RAM
        FROM Ordenagailuak
        WHERE ID = OLD.ID;

    END IF;

    -- Si es impresora
    IF EXISTS (SELECT 1 FROM Inprimagailuak WHERE ID = OLD.ID) THEN
        
        INSERT INTO Ezabatutako_inprimagailuak (ID, koloretakoa)
        SELECT ID, koloretakoa
        FROM Inprimagailuak
        WHERE ID = OLD.ID;

    END IF;

END //

DELIMITER ;