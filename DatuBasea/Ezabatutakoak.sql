CREATE TABLE Ezabatuak (
    ID VARCHAR(50),
    marka VARCHAR(100),
    kokalekua VARCHAR(100),
    erostedata DATE,
    IDMintegia VARCHAR(50),
    PRIMARY KEY (ID),
    FOREIGN KEY (IDMintegia) REFERENCES Mintegiak(ID)
);
CREATE TABLE Ezabatutako_ordenagailuak (
    ID VARCHAR(50),
    marka VARCHAR(100),
    kokalekua VARCHAR(100),
    erostedata DATE,
    IDMintegia VARCHAR(50),
    CPU VARCHAR(100),
    RAM VARCHAR(50),
    PRIMARY KEY (ID),
    FOREIGN KEY (ID) REFERENCES Ezabatuak(ID),
    FOREIGN KEY (IDMintegia) REFERENCES Mintegiak(ID)
);

CREATE TABLE Ezabatutako_inprimagailuak (
    ID VARCHAR(50),
    marka VARCHAR(100),
    kokalekua VARCHAR(100),
    erostedata DATE,
    IDMintegia VARCHAR(50),
    koloretakoa VARCHAR(3),
    PRIMARY KEY (ID),
    FOREIGN KEY (ID) REFERENCES Ezabatuak(ID),
    FOREIGN KEY (IDMintegia) REFERENCES Mintegiak(ID)
);