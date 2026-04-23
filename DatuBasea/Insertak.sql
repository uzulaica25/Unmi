INSERT INTO Mintegiak (ID, izena) VALUES
('M06', 'Erizaintza'),

('M03', 'Administrazioa'),
('M04', 'Burdingintza');


INSERT INTO Erabiltzaileak (ID, izena, pasahitza, IDMintegia) VALUES
('U14', 'Ane', 'abcdabcd', 'M01'),
('U03', 'Jon', 'passpass', 'M02'),
('U04', 'Leire', 'qwertyui', 'M03'),
('U05', 'Juan', 'abcdabcd', 'M04'),
('U06', 'Felipe', 'passpass', 'M05'),
('U07', 'Miren', 'qwertyui', 'M06'),
('U08', 'Antxon', '1245678', 'M01'),
('U09', 'Eneritz', 'passpass', 'M02'),
('U10', 'Alaitz', 'qwertyui', 'M03'),
('U11', 'Maria', 'abcdabcd', 'M04'),
('U12', 'Iraitz', 'passpass', 'M05'),
('U13', 'Sandra', 'qwertyui', 'M06');

INSERT INTO Irakaslea VALUES
('U14', 'Ane', 'abcdabcd', 'M01'),
('U03', 'Jon', 'passpass', 'M02'),
('U04', 'Leire', 'qwertyui', 'M03'),
('U05', 'Juan', 'abcdabcd', 'M04'),
('U06', 'Felipe', 'passpass', 'M05'),
('U07', 'Miren', 'qwertyui', 'M06');

INSERT INTO MintegiBurua VALUES
('U08', 'Antxon', '1245678', 'M01'),
('U09', 'Eneritz', 'passpass', 'M02'),
('U10', 'Alaitz', 'qwertyui', 'M03'),
('U11', 'Maria', 'abcdabcd', 'M04'),
('U12', 'Iraitz', 'passpass', 'M05'),
('U13', 'Sandra', 'qwertyui', 'M06');

INSERT INTO Gailuak (ID, marka, kokalekua, erostedata, IDMintegia) VALUES
-- M01
('G05', 'Dell', 'Gela3', '2023-02-15', 'M01'),
('G06', 'Lenovo', 'Bulegoa2', '2022-08-10', 'M01'),
('G07', 'HP', 'Gela1', '2021-12-01', 'M01'),

-- M02
('G08', 'HP', 'Gela2', '2023-03-12', 'M02'),
('G09', 'Dell', 'Gela4', '2022-06-25', 'M02'),
('G10', 'Lenovo', 'Bulegoa', '2021-09-18', 'M02'),

-- M03
('G11', 'Canon', 'Idazkaritza', '2023-01-05', 'M03'),
('G12', 'HP', 'Gela3', '2022-04-14', 'M03'),
('G13', 'Dell', 'Gela2', '2021-07-30', 'M03'),

-- M04
('G14', 'Lenovo', 'Gela1', '2023-05-20', 'M04'),
('G15', 'HP', 'Bulegoa', '2022-10-11', 'M04'),
('G16', 'Dell', 'Gela4', '2021-03-22', 'M04'),

-- M05
('G17', 'Canon', 'Idazkaritza', '2023-06-01', 'M05'),
('G18', 'HP', 'Gela2', '2022-11-09', 'M05'),
('G19', 'Lenovo', 'Bulegoa', '2021-08-17', 'M05'),

-- M06
('G20', 'Dell', 'Gela3', '2023-07-13', 'M06'),
('G21', 'HP', 'Gela1', '2022-02-28', 'M06'),
('G22', 'Lenovo', 'Bulegoa2', '2021-05-06', 'M06');

INSERT INTO Ordenagailuak VALUES
('G05', 'Dell', 'Gela3', '2023-02-15', 'M01','i4', '13GB'),
('G06', 'Lenovo', 'Bulegoa2', '2022-08-10', 'M01','i5', '16GB'),
('G08', 'HP', 'Gela2', '2023-03-12', 'M02','i7', '18GB'),
('G09', 'Dell', 'Gela4', '2022-06-25', 'M02','i2', '13GB'),
('G11', 'Canon', 'Idazkaritza', '2023-01-05', 'M03','i6', '19GB'),
('G12', 'HP', 'Gela3', '2022-04-14', 'M03','i4', '13GB'),
('G14', 'Lenovo', 'Gela1', '2023-05-20', 'M04','i6', '12GB'),
('G15', 'HP', 'Bulegoa', '2022-10-11', 'M04','i4', '8GB'),
('G17', 'Canon', 'Idazkaritza', '2023-06-01', 'M05','i9', '16GB'),
('G18', 'HP', 'Gela2', '2022-11-09', 'M05','i3', '13GB'),
('G20', 'Dell', 'Gela3', '2023-07-13', 'M06','i4', '16GB'),
('G21', 'HP', 'Gela1', '2022-02-28', 'M06','i5', '13GB');

INSERT INTO Inprimagailuak VALUES
('G07', 'HP', 'Gela1', '2021-12-01', 'M01', 'Bai'),
('G10', 'Lenovo', 'Bulegoa', '2021-09-18', 'M02', 'Ez'),
('G13', 'Dell', 'Gela2', '2021-07-30', 'M03', 'Ez'),
('G16', 'Dell', 'Gela4', '2021-03-22', 'M04', 'Bai'),
('G19', 'Lenovo', 'Bulegoa', '2021-08-17', 'M05', 'Ez'),
('G22', 'Lenovo', 'Bulegoa2', '2021-05-06', 'M06', 'Bai');

INSERT INTO Intzidentziak VALUES
('I01', '2024-02-10', 'Pantaila ez dabil', 'G05'),
('I02', '2024-03-01', 'Paper falta', 'G19'),
('I03', '2024-03-15', 'Oso motel doa', 'G18');

INSERT INTO Ezabatuak VALUES
('E01', 'G23', 'Acer', 'Biltegia', '2019-06-10', 'M01'),
('E02', 'G24','Epson', 'Biltegia', '2018-02-02', 'M02');

INSERT INTO Ezabatutako_ordenagailuak VALUES
('E01', 'G23','Acer', 'Biltegia', '2019-06-10', 'M01', 'i3', '4GB');

INSERT INTO Ezabatutako_inprimagailuak VALUES
('E02', 'G24', 'Epson', 'Biltegia', '2018-02-02', 'M02', 'Bai');