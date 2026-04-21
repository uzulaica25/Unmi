INSERT INTO Mintegiak (ID, izena) VALUES
('M01', 'Informatika'),
('M02', 'Elektronika'),
('M03', 'Administrazioa');

INSERT INTO Erabiltzaileak (ID, izena, pasahitza, IDMintegia) VALUES
('U01', 'Mikel', '1234', 'M01'),
('U02', 'Ane', 'abcd', 'M02'),
('U03', 'Jon', 'pass', 'M01'),
('U04', 'Leire', 'qwerty', 'M03');

INSERT INTO IKTArduraduna VALUES
('U01', 'Mikel', '1234', 'M01');

INSERT INTO Irakaslea VALUES
('U02', 'Ane', 'abcd', 'M02'),
('U03', 'Jon', 'pass', 'M01');

INSERT INTO MintegiBurua VALUES
('U04', 'Leire', 'qwerty', 'M03');

INSERT INTO Gailuak (ID, marka, kokalekua, erostedata, IDMintegia) VALUES
('G01', 'Dell', 'Gela1', '2023-01-10', 'M01'),
('G02', 'HP', 'Gela2', '2022-05-20', 'M02'),
('G03', 'Lenovo', 'Bulegoa', '2021-11-15', 'M01'),
('G04', 'Canon', 'Idazkaritza', '2020-03-05', 'M03');

INSERT INTO Ordenagailuak VALUES
('G01', 'Dell', 'Gela1', '2023-01-10', 'M01', 'i5', '8GB'),
('G03', 'Lenovo', 'Bulegoa', '2021-11-15', 'M01', 'i7', '16GB');

INSERT INTO Inprimagailuak VALUES
('G02', 'HP', 'Gela2', '2022-05-20', 'M02', 'Bai'),
('G04', 'Canon', 'Idazkaritza', '2020-03-05', 'M03', 'Ez');

INSERT INTO Intzidentziak VALUES
('I01', '2024-02-10', 'Pantaila ez dabil', 'G01'),
('I02', '2024-03-01', 'Paper falta', 'G02'),
('I03', '2024-03-15', 'Oso motel doa', 'G03');

INSERT INTO Ezabatuak VALUES
('E01', 'Acer', 'Biltegia', '2019-06-10', 'M01'),
('E02', 'Epson', 'Biltegia', '2018-02-02', 'M02');

INSERT INTO Ezabatutako_ordenagailuak VALUES
('E01', 'Acer', 'Biltegia', '2019-06-10', 'M01', 'i3', '4GB');

INSERT INTO Ezabatutako_inprimagailuak VALUES
('E02', 'Epson', 'Biltegia', '2018-02-02', 'M02', 'Bai');