
CREATE DATABASE IF NOT EXISTS mozi COLLATE = 'utf8_hungarian_ci';

USE mozi;

CREATE TABLE IF NOT EXISTS Ember (
    EAZON INT AUTO_INCREMENT PRIMARY KEY,
    NEV VARCHAR(255)
);

CREATE TABLE IF NOT EXISTS Mozi (
    MOAZON INT AUTO_INCREMENT PRIMARY KEY,
    NEV VARCHAR(255),
    KERULET INT,
    TIPUS VARCHAR(255)
);

CREATE TABLE IF NOT EXISTS Film (
    FAZON INT AUTO_INCREMENT PRIMARY KEY,
    CIM VARCHAR(255),
    HOSSZ INT,
    MUFAJ VARCHAR(255),
    RENDEZO INT,
    GYART_EV INT,
    SZARMAZAS VARCHAR(255),
    FOREIGN KEY (RENDEZO) REFERENCES Ember(EAZON)
);

CREATE TABLE IF NOT EXISTS Musor (
    MUAZON INT AUTO_INCREMENT PRIMARY KEY,
    FAZON INT,
    MOAZON INT,
    DATUM DATE,
    IDOPONT TIME,
    FOREIGN KEY (FAZON) REFERENCES Film(FAZON),
    FOREIGN KEY (MOAZON) REFERENCES Mozi(MOAZON)
);

CREATE TABLE IF NOT EXISTS Szerepel (
    FAZON INT,
    EAZON INT,
    PRIMARY KEY (FAZON, EAZON),
    FOREIGN KEY (FAZON) REFERENCES Film(FAZON),
    FOREIGN KEY (EAZON) REFERENCES Ember(EAZON)
);

-- Cirko-Gejzír 2023-12-19 rendező
INSERT INTO Ember (EAZON, NEV) VALUES
(NULL, 'Dani Rosenberg'),
(NULL, 'Roman Polanski'),
(NULL, 'Hafsteinn Gunnar Sigurðsson'),
(NULL, 'Reisz Gábor'),
(NULL, 'Roman Polanski'),
(NULL, 'Gilles Legardinier'),
(NULL, 'Justine Triet'),
(NULL, 'Roman Polanski'),
(NULL, 'Dani Rosenberg');

-- Cirko-Gejzír 2023-12-19 film
INSERT INTO Film (FAZON, CIM, HOSSZ, MUFAJ, RENDEZO, GYART_EV, SZARMAZAS) VALUES
(NULL, 'Az eltűnt katona', 105, 'háborús filmdráma', 1, 2023, 'izraeli-francia'),
(NULL, 'Palace Hotel', 100, 'filmdráma', 2, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Repülés kezdőknek', 97, 'vígjáték', 3, 2023, 'angol-izlandi-német'),
(NULL, 'Magyarázat mindenre', 151, 'játékfilm', 4, 2023, 'magyar '),
(NULL, 'Palace Hotel', 100, 'filmdráma', 5, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Vendég a francia kastélyban', 110, 'romantikus vígjáték ', 6, 2023, 'francia'),
(NULL, 'Egy zuhanás anatómiája', 150, 'thriller, dráma, krimi,', 7, 2023, 'francia'),
(NULL, 'Palace Hotel', 100, 'filmdráma', 8, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Az eltűnt katona', 105, 'izraeli-francia háborús filmdráma', 9, 2023, 'izraeli-francia');

-- Cirko-Gejzír 2023-12-19 mozi
INSERT INTO Mozi (MOAZON, NEV, KERULET, TIPUS) VALUES
(NULL, 'Cirko-Gejzír', 5, 'Art Cinema');

-- Cirko-Gejzír 2023-12-19 műsor
INSERT INTO Musor (FAZON, MOAZON, DATUM, IDOPONT) VALUES
(1, 1, '2023-12-19', '16:00'),
(2, 1, '2023-12-19', '16:15'),
(3, 1, '2023-12-19', '16:30'),
(4, 1, '2023-12-19', '18:00'),
(5, 1, '2023-12-19', '18:15'),
(6, 1, '2023-12-19', '18:30'),
(7, 1, '2023-12-19', '20:15'),
(8, 1, '2023-12-19', '20:45'),
(9, 1, '2023-12-19', '21:00');

-- Cirko-Gejzír 2023-12-19 insertek vége ----------


-- Cirko-Gejzír 2023-12-20 film
INSERT INTO Film (FAZON, CIM, HOSSZ, MUFAJ, RENDEZO, GYART_EV, SZARMAZAS) VALUES
(NULL, 'Az eltűnt katona', 105, 'háborús filmdráma', 1, 2023, 'izraeli-francia'),
(NULL, 'Palace Hotel', 100, 'filmdráma', 2, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Repülés kezdőknek', 97, 'vígjáték', 3, 2023, 'angol-izlandi-német'),
(NULL, 'Magyarázat mindenre', 151, 'játékfilm', 4, 2023, 'magyar '),
(NULL, 'Palace Hotel', 100, 'filmdráma', 5, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Vendég a francia kastélyban', 110, 'romantikus vígjáték ', 6, 2023, 'francia'),
(NULL, 'Egy zuhanás anatómiája', 150, 'thriller, dráma, krimi,', 7, 2023, 'francia'),
(NULL, 'Palace Hotel', 100, 'filmdráma', 8, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Az eltűnt katona', 105, 'izraeli-francia háborús filmdráma', 9, 2023, 'izraeli-francia');

-- Cirko-Gejzír 2023-12-20 műsor
INSERT INTO Musor (FAZON, MOAZON, DATUM, IDOPONT) VALUES
(1, 1, '2023-12-20', '16:00'),
(2, 1, '2023-12-20', '16:15'),
(3, 1, '2023-12-20', '16:30'),
(4, 1, '2023-12-20', '18:00'),
(5, 1, '2023-12-20', '18:15'),
(6, 1, '2023-12-20', '18:30'),
(7, 1, '2023-12-20', '20:15'),
(8, 1, '2023-12-20', '20:45'),
(9, 1, '2023-12-20', '21:00');

-- Cirko-Gejzír vége ----- ----- ----- ----- -----


-- Művész mozi 2023-12-19 rendező
INSERT INTO Ember (EAZON, NEV) VALUES
(NULL, 'Guy Nattiv'),
(NULL, 'Paul King'),
(NULL, 'Reisz Gábor'),
(NULL, 'Hevér Dániel'),
(NULL, "Thaddeus O'Sullivan"),
(NULL, 'Michal Kwieciński'),
(NULL, 'NaN'),
(NULL, 'Gilles Legardinier'),
(NULL, 'Justine Triet'),
(NULL, 'Roman Polanski'),
(NULL, 'Paul King'),
(NULL, 'Guy Nattiv'),
(NULL, 'NaN'),
(NULL, 'Roman Polanski'),
(NULL, 'Hevér Dániel'),
(NULL, 'DK Welchman & Hugh Welchman'),
(NULL, 'Ridley Scott'),
(NULL, 'Justine Triet'),
(NULL, 'Reisz Gábor'),
(NULL, 'Tóth Barnabás');

-- Művész-mozi 2023-12-19 film
INSERT INTO Film (FAZON, CIM, HOSSZ, MUFAJ, RENDEZO, GYART_EV, SZARMAZAS) VALUES
(NULL, 'Golda', 100, 'háborús filmdráma, életrajzi film', 10, 2023, 'angol'),
(NULL, 'Wonka', 112 , 'családi kalandfilm, vígjáték', 11, 2023, 'amerikai'),
(NULL, 'Magyarázat mindenre', 151, 'játékfilm', 12, 2023, 'magyar'),
(NULL, 'Valami madarak', 90, 'játékfilm', 13, 2023, 'magyar'),
(NULL, 'A csodák útján', 90, 'dráma', 14, 2023, 'ír-angol'),
(NULL, 'Filip', 124, 'dráma', 15, 2023, 'lengyel'),
(NULL, 'Semmelweis', 127, 'életrajzi, dráma', 16, 2023, 'magyar'),
(NULL, 'Vendég a francia kastélyban', 110, 'romantikus vígjáték', 17, 2023, 'francia'),
(NULL, 'Egy zuhanás anatómiája', 150, 'thriller, dráma, krimi', 18, 2023, 'francia'),
(NULL, 'Palace Hotel', 100, 'filmdráma', 19, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Wonka', 112 , 'családi kalandfilm, vígjáték', 20, 2023, 'amerikai'),
(NULL, 'Golda', 100, 'háborús filmdráma, életrajzi film', 21, 2023, 'angol'),
(NULL, 'Semmelweis', 127, 'életrajzi, dráma', 22, 2023, 'magyar'),
(NULL, 'Palace Hotel', 100, 'filmdráma', 23, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Valami madarak', 90, 'játékfilm', 24, 2023, 'magyar'),
(NULL, 'Parasztok', 114, 'dráma, animációs film', 25, 2023, 'lengyel'),
(NULL, 'Napóleon', 157, 'történelmi dráma, életrajzi dráma, háborús filmdráma', 26, 2023, 'amerikai '),
(NULL, 'Egy zuhanás anatómiája', 150, 'thriller, dráma, krimi', 27, 2023, 'francia'),
(NULL, 'Magyarázat mindenre', 151, 'játékfilm', 28, 2023, 'magyar'),
(NULL, 'Mesterjátszma', 90, 'pszichothriller', 29, 2023, 'magyar');

-- Művész mozi 2023-12-19 mozi
INSERT INTO Mozi (MOAZON, NEV, KERULET, TIPUS) VALUES
(NULL, 'Művész mozi', 6, 'Art Cinema');

-- Művész mozi 2023-12-19 műsor
INSERT INTO Musor (FAZON, MOAZON, DATUM, IDOPONT) VALUES
(10, 2, '2023-12-19', '13:15'),
(11, 2, '2023-12-19', '13:15'),
(12, 2, '2023-12-19', '14:00'),
(13, 2, '2023-12-19', '14:00'),
(14, 2, '2023-12-19', '14:15'),
(15, 2, '2023-12-19', '15:15'),
(16, 2, '2023-12-19', '15:30'),
(17, 2, '2023-12-19', '15:45'),
(18, 2, '2023-12-19', '16:15'),
(19, 2, '2023-12-19', '17:00'),
(20, 2, '2023-12-19', '17:45'),
(21, 2, '2023-12-19', '17:45'),
(22, 2, '2023-12-19', '18:00'),
(23, 2, '2023-12-19', '19:00'),
(24, 2, '2023-12-19', '19:00'),
(25, 2, '2023-12-19', '19:45'),
(26, 2, '2023-12-19', '20:00'),
(27, 2, '2023-12-19', '20:30'),
(28, 2, '2023-12-19', '20:45'),
(29, 2, '2023-12-19', '20:45'),
(30, 2, '2023-12-19', '21:15');

-- Művész mozi insertek vége ----- ----- ----- ----- -----

-- Puskin mozi 2023-12-20 rendező
INSERT INTO Ember (EAZON, NEV) VALUES
(NULL, "Thaddeus O'Sullivan"),
(NULL, 'Hevér Dániel'),
(NULL, 'NaN'),
(NULL, 'Guy Nattiv'),
(NULL, 'Monia Chokri'),
(NULL, "Thaddeus O'Sullivan"),
(NULL, 'Roman Polanski'),
(NULL, 'Justine Triet'),
(NULL, 'Paul King'),
(NULL, 'Moldovai Katalin'),
(NULL, 'Eric Toledano & Olivier Nakache'),
(NULL, 'Gilles Legardinier'),
(NULL, 'NaN'),
(NULL, 'Justine Triet'),
(NULL, 'Hafsteinn Gunnar Sigurðsson'),
(NULL, 'Gilles Legardinier'),
(NULL, 'Roman Polanski');

-- Puskin mozi 2023-12-20 film
INSERT INTO Film (FAZON, CIM, HOSSZ, MUFAJ, RENDEZO, GYART_EV, SZARMAZAS) VALUES
(NULL, 'A csodák útján', 90, 'dráma', 30, 2023, 'ír-angol'),
(NULL, 'Valami madarak', 90, 'játékfilm', 31, 2023, 'magyar'),
(NULL, 'Semmelweis', 127, 'életrajzi, dráma', 32, 2023, 'magyar'),
(NULL, 'Golda', 100, 'háborús filmdráma, életrajzi film', 33, 2023, 'angol'),
(NULL, 'A szerelem természete', 110, '-', 34, 2023, '-'),
(NULL, 'A csodák útján', 90, 'dráma', 35, 2023, 'ír-angol'),
(NULL, 'Palace Hotel', 100, 'filmdráma', 36, 2023, 'olasz-svájci-lengyel-francia'),
(NULL, 'Egy zuhanás anatómiája', 150, 'thriller, dráma, krimi', 37, 2023, 'francia'),
(NULL, 'Wonka', 112 , 'családi kalandfilm, vígjáték', 38, 2023, 'amerikai'),
(NULL, 'Elfogy a levegő', 104, 'filmdráma', 39, 2023, 'magyar'),
(NULL, 'Ennél csak jobb jöhet', 120, 'vígjáték', 40, 2023, 'francia '),
(NULL, 'Vendég a francia kastélyban', 110, 'romantikus vígjáték', 41, 2023, 'francia'),
(NULL, 'Semmelweis', 127, 'életrajzi, dráma', 42, 2023, 'magyar'),
(NULL, 'Egy zuhanás anatómiája', 150, 'thriller, dráma, krimi', 43, 2023, 'francia'),
(NULL, 'Repülés kezdőknek', 97, 'vígjáték', 44, 2023, 'angol-izlandi-német'),
(NULL, 'Vendég a francia kastélyban', 110, 'romantikus vígjáték', 45, 2023, 'francia'),
(NULL, 'Palace Hotel', 100, 'filmdráma', 46, 2023, 'olasz-svájci-lengyel-francia');

-- Puskin mozi 2023-12-20 mozi
INSERT INTO Mozi (MOAZON, NEV, KERULET, TIPUS) VALUES
(NULL, 'Puskin', 5, 'Art Cinema');

-- Puskin mozi 2023-12-20 műsor
INSERT INTO Musor (FAZON, MOAZON, DATUM, IDOPONT) VALUES
(39, 3, '2023-12-20', '15:00'),
(40, 3, '2023-12-20', '15:00'),
(41, 3, '2023-12-20', '15:00'),
(42, 3, '2023-12-20', '15:15'),
(43, 3, '2023-12-20', '16:15'),
(44, 3, '2023-12-20', '16:45'),
(45, 3, '2023-12-20', '16:45'),
(46, 3, '2023-12-20', '16:45'),
(47, 3, '2023-12-20', '17:15'),
(48, 3, '2023-12-20', '17:30'),
(48, 3, '2023-12-20', '18:15'),
(49, 3, '2023-12-20', '18:30'),
(50, 3, '2023-12-20', '18:30'),
(51, 3, '2023-12-20', '19:45'),
(52, 3, '2023-12-20', '20:00'),
(53, 3, '2023-12-20', '20:15'),
(54, 3, '2023-12-20', '20:30'),
(55, 3, '2023-12-20', '20:30');

INSERT INTO Szerepel (FAZON, EAZON) VALUES
(34,25),
(49,40);