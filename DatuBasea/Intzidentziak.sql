CREATE TABLE Intzidentziak (
    ID VARCHAR(50) ,
    data DATE,
    mezua VARCHAR(500),
    IDGailua VARCHAR(50),
    PRIMARY KEY (ID),
    FOREIGN KEY (IDGailua) REFERENCES Gailuak(ID)
);