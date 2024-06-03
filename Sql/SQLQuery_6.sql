SELECT TOP (1000) [BAGGAGEID]
      ,[SSN]
      ,[WEIGHT]
      ,[AIRCRAFT]
  FROM [FlightBookingSystemDatabase].[dbo].[LUGGAGE]

INSERT INTO [FlightBookingSystemDatabase].[dbo].[LUGGAGE]
([BAGGAGEID], [SSN], [WEIGHT], [AIRCRAFT])
VALUES
-- Generating 30 rows of data with random weights and assigning random aircraft IDs between 1 and 25
-- Ensure that the aircraft IDs exist in the AIRCRAFT table
(1, '123-45-6789', 20, 1),
(2, '234-56-7890', 15, 2),
(3, '345-67-8901', 30, 3),
(4, '456-78-9012', 25, 4),
(5, '567-89-0123', 18, 5),
(6, '123-45-6789', 22, 6),
(7, '234-56-7890', 28, 7),
(8, '345-67-8901', 17, 8),
(9, '456-78-9012', 32, 9),
(10, '567-89-0123', 23, 10),
(11, '123-45-6789', 19, 11),
(12, '234-56-7890', 24, 12),
(13, '345-67-8901', 26, 13),
(14, '456-78-9012', 21, 14),
(15, '567-89-0123', 27, 15),
(16, '123-45-6789', 16, 16),
(17, '234-56-7890', 29, 17),
(18, '345-67-8901', 31, 18),
(19, '456-78-9012', 22, 19),
(20, '567-89-0123', 20, 20),
(21, '123-45-6789', 18, 21),
(22, '234-56-7890', 26, 22),
(23, '345-67-8901', 15, 23),
(24, '456-78-9012', 23, 24),
(25, '567-89-0123', 28, 25),
(26, '123-45-6789', 20, 1),
(27, '234-56-7890', 15, 2),
(28, '345-67-8901', 30, 3),
(29, '456-78-9012', 25, 4),
(30, '567-89-0123', 18, 5);