CREATE TABLE Erabiltzaileak (
    ID VARCHAR(10),
    izena VARCHAR(100),
    pasahitza VARCHAR(255),
    IDMintegia VARCHAR(50),
    PRIMARY KEY (ID),
    FOREIGN KEY (IDMintegia) REFERENCES Mintegiak(ID)
);

CREATE TABLE IKTArduraduna (
    ID VARCHAR(10),
    PRIMARY KEY (ID),
    FOREIGN KEY (ID) REFERENCES Erabiltzaileak(ID)
);

CREATE TABLE Irakaslea (
    ID VARCHAR(10),
    PRIMARY KEY (ID),
    FOREIGN KEY (ID) REFERENCES Erabiltzaileak(ID)
);

CREATE TABLE MintegiBurua (
    ID VARCHAR(10),
	PRIMARY KEY (ID),
    FOREIGN KEY (ID) REFERENCES Erabiltzaileak(ID)
);