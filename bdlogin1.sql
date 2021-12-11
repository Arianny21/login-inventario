-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-12-2021 a las 03:05:47
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdlogin1`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `IdProducto` int(11) NOT NULL,
  `NombreProducto` varchar(140) NOT NULL,
  `Marca` varchar(140) NOT NULL,
  `Categoria` varchar(11) NOT NULL,
  `Precio` int(11) NOT NULL,
  `CantDispo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`IdProducto`, `NombreProducto`, `Marca`, `Categoria`, `Precio`, `CantDispo`) VALUES
(2, 'cafe', 'santo domingo', 'comida', 250, 10),
(4, 'xiaomi note 9', 'redmi', 'celulares', 12500, 6),
(5, 'laptop', 'dell ', 'tecnologia', 25000, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Id` int(20) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(20) NOT NULL,
  `Telefono` varchar(12) NOT NULL,
  `Email` varchar(20) NOT NULL,
  `Contraseña` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Id`, `Nombre`, `Apellido`, `Telefono`, `Email`, `Contraseña`) VALUES
(1, 'Arianna', 'Rodriguez', '8293698719', 'rarianny725@gmail.co', '123456'),
(3, 'Adrian', 'Rodriguez', '8293698719', 'adrian@hotmail.com', '13456'),
(6, 'Tania', 'Ogando', '8293698714', 'tania@gmail.com', '123456'),
(7, 'Darwil', 'Sanchez', '8295874785', 'darwil@gmail.com', '123458'),
(9, 'tana', 'ogando', '8295879478', 'tana@gmail.com', '12345678'),
(10, 'Violett', 'Dicent', '8295478956', 'violet@hotmail.com', '12345'),
(12, 'Nana', 'Valenzuela', '8295478521', 'nana@gmail.com', '12345'),
(13, 'Rachell', 'Mendez', '8096324521', 'rachellm@gmail.com', '123456');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`IdProducto`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `IdProducto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
