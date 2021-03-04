-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 06 Gru 2020, 19:55
-- Wersja serwera: 10.4.14-MariaDB
-- Wersja PHP: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

CREATE DATABASE `pizzeria`;

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `pizzeria`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `allorders`
--

CREATE TABLE `allorders` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `history`
--

CREATE TABLE `history` (
  `id` bigint(20) NOT NULL,
  `dishes` varchar(1023) NOT NULL,
  `price` float NOT NULL,
  `adnotations` varchar(1023) NOT NULL,
  `order_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `menu`
--

CREATE TABLE `menu` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `ingrediences` varchar(1023) NOT NULL,
  `price` int(11) NOT NULL,
  `typ` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `menu`
--

INSERT INTO `menu` (`id`, `name`, `ingrediences`, `price`, `typ`) VALUES
(1, 'Margeritta', 'sos pomidorowy, ser mozzarella', 2000, 'pizza'),
(2, 'Vegetariana', 'sos pomidorowy, ser, papryka, pieczarki, brokuł, słonecznik', 2200, 'pizza'),
(3, 'Tosca', 'sos pomidorowy, ser mozzarella, rucola, pomidorki koktajlowe', 2500, 'pizza'),
(4, 'Venecia', 'sos pomidorowy, ser mozzarella, szynka, pieczarki, kukurydza, pomidor, krewetki', 2500, 'pizza'),
(5, 'Schabowy', 'kotlet schabowy, frytki/ryż/ziemniaki', 3000, 'pizza'),
(6, 'Ryba z frytkami', 'Ryba, frytki', 2800, 'obiad'),
(7, 'Placek po węgiersku', 'placki ziemniaczane, gulasz', 2700, 'obiad'),
(8, 'Zupa pomidorowa', 'bulion, przecier ze świeżych pomidorów, makaron', 1200, 'zupa'),
(9, 'Rosół', 'bulion, makaron', 1000, 'zupa'),
(10, 'Kawa', 'świeżo mielona kawa z ekspesu', 500, 'napój'),
(11, 'Herbata', 'świeżo parzona herbata', 500, 'napój'),
(12, 'Cola', 'napój gazowany o smaku cola w puszce', 500, 'napój');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `allorders`
--
ALTER TABLE `allorders`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `history`
--
ALTER TABLE `history`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `allorders`
--
ALTER TABLE `allorders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `history`
--
ALTER TABLE `history`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `menu`
--
ALTER TABLE `menu`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
