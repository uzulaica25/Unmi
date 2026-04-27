INBENTARIOA – Gailu digitalen kudeaketa sistema
1.Proiektuaren deskribapena

Proiektu honen helburua ikastetxe bateko gailu digitalen inbentarioa kudeatzeko aplikazio bat garatzea da. Aplikazioak erabiltzaileei aukera emango die gailuen informazioa modu erraz eta intuitiboan gehitu, kontsultatu eta kudeatzeko.

Sistema honek datu base zentralizatu bat erabiliko du, ekipamendu guztien informazioa egituratuta gordetzeko eta aldaketak denbora errealean partekatzeko.

2.Helburu nagusiak
  Gailu digitalen kontrola eta kudeaketa erraztea
  Datuen biltegiratze egituratua bermatzea
  Erabiltzaile rol desberdinak kudeatzea
  Gailuen bizi-zikloaren jarraipena egitea
  Jasangarritasuna eta berrerabilpena sustatzea
  
3.Funtzionalitateak
  Gailuen erregistroa (ordenagailuak, inprimagailuak...)
  Gailuen kontsulta eta filtraketa
  Datuen edizioa eta ezabaketa
  Ezabatutako gailuen historikoa (trigger bidez)
  Erabiltzaile rolak:
    Irakaslea → kontsulta bakarrik
    Mintegi burua → bere mintegiko kudeaketa
    IKT arduraduna → gailu guztien kontrol osoa
  IoT bidez biltegiaren baldintzen monitorizazioa (tenperatura eta hezetasuna)

4.Arkitektura
  Frontend: Windows Form aplikazioa (interfaze grafikoa)
  Backend: Datu base erlazionala (MySQL edo antzekoa)
  Arkitektura: Bezero-zerbitzari eredua
  Kontrol sistema: Git (versionaketa eta lankidetza)

5.Datu basearen egitura

Sistema honek hainbat entitate nagusi ditu:

  Gailuak
    Ordenagailuak
    Inprimagailuak
  Erabiltzaileak
    Irakasleak
    Mintegi Buruak
    IKT Arduradunak
  Mintegiak
  Intzidentziak
  Ezabatuak
    Ezanatutako_ordenagailuak
    Ezabatutako_Inprimagailuak
  
6.Web orrialdea

Proiektuak web orri korporatibo bat ere barne hartzen du:

Produktuaren aurkezpena
Instaladorearen deskarga
Dokumentazio teknikoa
Bideo tutoriala (ingelesez)
Harremanetarako formularioa

Erabiltzaile motak:
Publikoa → informazioa kontsultatu
Administratzailea → baliabide gehigarriak eskuratu

7.Erabiltzaile baimenak

Sistema rol bidez kudeatzen da, erabiltzaile bakoitzak bere baimen mailaren arabera jarduteko:

Rola	Baimentutako ekintzak
Irakaslea	Ikusi
Mintegi burua	Bere mintegiko gailuak, intzidentziak eta erabiltzaileak kudeatu
IKT arduraduna	gailu, erabiltzailea, intzidentzia, mintegi guztiak kudeatu

8.Jasangarritasuna

Proiektuak ekonomia zirkularra sustatzen du:

Gailuen berrerabilpena lehenesten da
Mantentzea ordezkapenaren aurretik
Gailuen bizi-zikloaren jarraipena
Hondakin elektronikoen murrizketa
