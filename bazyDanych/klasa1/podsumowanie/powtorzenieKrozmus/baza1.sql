-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 29 Maj 2021, 09:52
-- Wersja serwera: 10.4.17-MariaDB
-- Wersja PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `baza1`
--
CREATE DATABASE IF NOT EXISTS `baza1` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `baza1`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `imie` varchar(25) NOT NULL,
  `nazwisko` varchar(30) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `wiek` int(3) DEFAULT NULL,
  `data_rejestracji` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `users`
--

INSERT INTO `users` (`id`, `imie`, `nazwisko`, `email`, `wiek`, `data_rejestracji`) VALUES
(1, 'Adam', 'Rogal', 'adamr232@gmail.com', 32, '2014-10-13'),
(2, 'Zbigniew', 'Aleksandrowicz', 'za@zag.org', 59, '2012-04-23'),
(3, 'Piotr', 'Quake', 'qauke_piotr@happy_pony.org', 72, '1998-02-22'),
(4, 'Hermenegilda', 'Konstantynopolitańczykiewiczów', 'kk1998@gmail.com', 40, '2000-01-22');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
