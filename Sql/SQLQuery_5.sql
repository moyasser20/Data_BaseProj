SELECT TOP (1000) [DEPARTUREDATETIME]
      ,[DESTINATIONAIRPORTNAME]
      ,[ARRIVALDATETIME]
      ,[STATUS]
      ,[AVAILABLESEATS]
      ,[ORIGINAIRPORTNAME]
      ,[FLIGHT_ID]
      ,[ADMIN_SSN]
  FROM [FlightBookingSystemDatabase].[dbo].[FLIGHT]

ALTER TABLE [FlightBookingSystemDatabase].[dbo].[FLIGHT]
ADD CONSTRAINT FK_FLIGHT_ORIGINAIRPORT
FOREIGN KEY (ORIGINAIRPORTNAME) REFERENCES [FlightBookingSystemDatabase].[dbo].[AIRPORT](AIRPORTNAME);

ALTER TABLE [FlightBookingSystemDatabase].[dbo].[FLIGHT]
ADD CONSTRAINT FK_FLIGHT_DESTINATIONAIRPORT
FOREIGN KEY (DESTINATIONAIRPORTNAME) REFERENCES [FlightBookingSystemDatabase].[dbo].[AIRPORT](AIRPORTNAME);


-- Drop the foreign key constraint that references AIRPORTNAME
ALTER TABLE [FlightBookingSystemDatabase].[dbo].[FLIGHT]
DROP CONSTRAINT FK_FLIGHT_FLIES_TO_AIRPORT;

-- Drop the index that depends on the AIRPORTNAME column if necessary
DROP INDEX FLIES_TO_FK ON [FlightBookingSystemDatabase].[dbo].[FLIGHT];

ALTER TABLE [FlightBookingSystemDatabase].[dbo].[FLIGHT]
DROP COLUMN [AIRPORTNAME];


INSERT INTO [FlightBookingSystemDatabase].[dbo].[FLIGHT]
([DEPARTUREDATETIME], [DESTINATIONAIRPORTNAME], [ARRIVALDATETIME], [STATUS], [AVAILABLESEATS], [ORIGINAIRPORTNAME], [FLIGHT_ID], [ADMIN_SSN])
VALUES
('2023-01-15 08:00:00', 'Cairo Airport', '2023-01-15 11:00:00', 'On Time', 150, 'Giza Airport', 1, '123-45-6789'),
('2023-02-20 09:00:00', 'London Airport', '2023-02-20 21:00:00', 'Delayed', 200, 'Toronto Airport', 2, '234-56-7890'),
('2023-03-05 10:30:00', 'Sydney Airport', '2023-03-05 20:00:00', 'Cancelled', 0, 'Rome Airport', 3, '345-67-8901'),
('2023-04-12 07:00:00', 'Paris Airport', '2023-04-12 19:00:00', 'On Time', 180, 'Dubai Airport', 4, '456-78-9012'),
('2023-05-22 11:00:00', 'Berlin Airport', '2023-05-22 23:00:00', 'On Time', 160, 'Seoul Airport', 5, '567-89-0123'),
('2023-06-30 14:00:00', 'Reyad Airport', '2023-06-30 23:00:00', 'On Time', 175, 'Cairo Airport', 6, '123-45-6789'),
('2023-07-19 18:00:00', 'Giza Airport', '2023-07-20 10:00:00', 'On Time', 190, 'London Airport', 7, '234-56-7890'),
('2023-08-25 09:30:00', 'Toronto Airport', '2023-08-25 19:30:00', 'Delayed', 150, 'Sydney Airport', 8, '345-67-8901'),
('2023-09-14 11:45:00', 'Rome Airport', '2023-09-14 21:45:00', 'On Time', 180, 'Paris Airport', 9, '456-78-9012'),
('2023-10-01 13:15:00', 'Dubai Airport', '2023-10-02 07:15:00', 'On Time', 170, 'Berlin Airport', 10, '567-89-0123'),
('2023-11-05 16:00:00', 'Seoul Airport', '2023-11-06 02:00:00', 'On Time', 200, 'Reyad Airport', 11, '123-45-6789'),
('2023-12-20 18:30:00', 'Cairo Airport', '2023-12-20 21:30:00', 'On Time', 190, 'Giza Airport', 12, '234-56-7890'),
('2024-01-10 20:00:00', 'London Airport', '2024-01-11 05:00:00', 'On Time', 185, 'Toronto Airport', 13, '345-67-8901'),
('2024-02-15 07:15:00', 'Sydney Airport', '2024-02-15 15:15:00', 'Delayed', 160, 'Rome Airport', 14, '456-78-9012'),
('2024-03-20 09:00:00', 'Paris Airport', '2024-03-20 17:00:00', 'On Time', 170, 'Dubai Airport', 15, '567-89-0123'),
('2024-04-25 12:30:00', 'Berlin Airport', '2024-04-25 20:30:00', 'On Time', 180, 'Seoul Airport', 16, '123-45-6789'),
('2024-05-14 15:00:00', 'Reyad Airport', '2024-05-15 04:00:00', 'On Time', 190, 'Cairo Airport', 17, '234-56-7890'),
('2024-06-18 18:00:00', 'Giza Airport', '2024-06-18 21:00:00', 'On Time', 200, 'London Airport', 18, '345-67-8901'),
('2024-07-05 08:00:00', 'Toronto Airport', '2024-07-05 18:00:00', 'On Time', 175, 'Sydney Airport', 19, '456-78-9012'),
('2024-08-23 10:00:00', 'Rome Airport', '2024-08-23 20:00:00', 'On Time', 180, 'Paris Airport', 20, '567-89-0123');
