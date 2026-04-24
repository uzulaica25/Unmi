CREATE TABLE Gailuak (
    ID VARCHAR(50),
    marka VARCHAR(100),
    kokalekua VARCHAR(100),
    erostedata DATE,
    IDMintegia VARCHAR(50),
    PRIMARY KEY (ID),
    FOREIGN KEY (IDMintegia) REFERENCES Mintegiak(ID)
);
CREATE TABLE Ordenagailuak (
    ID VARCHAR(50),
    CPU VARCHAR(100),
    RAM VARCHAR(50),
    PRIMARY KEY (ID),
    FOREIGN KEY (ID) REFERENCES Gailuak(ID)
);

CREATE TABLE Inprimagailuak (
    ID VARCHAR(50),
    koloretakoa VARCHAR(3),
    PRIMARY KEY (ID),
    FOREIGN KEY (ID) REFERENCES Gailuak(ID)
);