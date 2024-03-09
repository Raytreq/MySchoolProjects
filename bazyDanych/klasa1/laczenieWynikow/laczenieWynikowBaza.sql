-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 25 Mar 2021, 14:38
-- Wersja serwera: 10.4.13-MariaDB
-- Wersja PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `laczeniewynikow`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `nauczyciele`
--

CREATE TABLE `nauczyciele` (
  `ID_NAUCZYCIEL` int(11) NOT NULL,
  `IMIE` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `NAZWISKO` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `PRZEDMIOT` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `nauczyciele`
--

INSERT INTO `nauczyciele` (`ID_NAUCZYCIEL`, `IMIE`, `NAZWISKO`, `PRZEDMIOT`) VALUES
(1, 'Mateusz', 'Biedulski', 'Matematyka'),
(2, 'Ewa', 'Machowska', 'J. Polski'),
(3, 'Mariusz', 'Borkowski', 'Geografia'),
(4, 'Karolina', 'Podolska', 'J. Angielski'),
(5, 'Lucjan', 'Piekarski', 'Biologia');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `oceny`
--

CREATE TABLE `oceny` (
  `ID_OCENY` int(11) NOT NULL,
  `OCENA` int(11) NOT NULL,
  `PELNA_NAZWA_OCENY` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `oceny`
--

INSERT INTO `oceny` (`ID_OCENY`, `OCENA`, `PELNA_NAZWA_OCENY`) VALUES
(1, 1, 'Niedostateczna'),
(2, 2, 'Dopuszczająca'),
(3, 3, 'Dostateczna'),
(4, 4, 'Dobry'),
(5, 5, 'Bardzo dobry'),
(6, 6, 'Celujący');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uczniowiee`
--

CREATE TABLE `uczniowiee` (
  `ID` int(11) NOT NULL,
  `IMIE` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `NAZWISKO` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `KLASA` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `PRZEDMIOT` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `OCENY_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `uczniowiee`
--

INSERT INTO `uczniowiee` (`ID`, `IMIE`, `NAZWISKO`, `KLASA`, `PRZEDMIOT`, `OCENY_ID`) VALUES
(1, 'Jan', 'Kowalski', '1ati', 'Matematyka', 2),
(2, 'Adam', 'Nowak', '1ati', 'J. Polski', 3),
(3, 'Anna', 'Wilk', '1bti', 'J. angielski', 4),
(4, 'Janina', 'Wolska', '1bti', 'Biologia', 5),
(5, 'Anna', 'Kwiatkowska', '2ati', 'Geografia', 4),
(6, 'Mateusz', 'Zieliński', '2ati', 'Geografia', 2),
(7, 'Ewa', 'Machowska', '2bti', 'J. angielski', 2),
(8, 'Piotr', 'Grzywacz', '2bti', 'Matematyka', 4),
(9, 'Anna', 'Duda', '3ati', 'J. Polski', 5),
(10, 'Arek', 'Skuza', '3bti', 'J. Polski', 2);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `nauczyciele`
--
ALTER TABLE `nauczyciele`
  ADD PRIMARY KEY (`ID_NAUCZYCIEL`);

--
-- Indeksy dla tabeli `oceny`
--
ALTER TABLE `oceny`
  ADD PRIMARY KEY (`ID_OCENY`);

--
-- Indeksy dla tabeli `uczniowiee`
--
ALTER TABLE `uczniowiee`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
