SELECT TOP (1000) [MODEL]
      ,[MANUDACTURE]
      ,[YEAROFMANUFACTURE]
      ,[LASTMAINTENACEDATE]
      ,[CAPACITY]
      ,[AIRCRAFTID]
      ,[FLIGHT_ID]
      ,[ADMIN_SSN]
      ,[STATUS]
      ,[AIRCRAFTNAME]
      ,[AIRPORTNAME]
  FROM [FlightBookingSystemDatabase].[dbo].[AIRCRAFT]


INSERT INTO [FlightBookingSystemDatabase].[dbo].[AIRCRAFT]
([MODEL], [MANUDACTURE], [YEAROFMANUFACTURE], [LASTMAINTENACEDATE], [CAPACITY], [AIRCRAFTID], [FLIGHT_ID], [ADMIN_SSN], [STATUS], [AIRCRAFTNAME], [AIRPORTNAME])
VALUES
('Boeing 737', 'Boeing', 2015, '2023-01-01', 150, 1, 1, '123-45-6789', 'Active', 'Boeing 737-100', 'Cairo Airport'),
('Airbus A320', 'Airbus', 2018, '2023-01-01', 180, 2, 2, '234-56-7890', 'Active', 'Airbus A320-200', 'Giza Airport'),
('Boeing 747', 'Boeing', 2016, '2023-01-01', 300, 3, 3, '345-67-8901', 'Inactive', 'Boeing 747-400', 'London Airport'),
('Airbus A380', 'Airbus', 2017, '2023-01-01', 500, 4, 4, '456-78-9012', 'Active', 'Airbus A380-800', 'Toronto Airport'),
('Embraer E190', 'Embraer', 2019, '2023-01-01', 100, 5, 5, '567-89-0123', 'Active', 'Embraer E190-100', 'Sydney Airport'),
('Boeing 787', 'Boeing', 2014, '2023-01-01', 250, 6, 6, '123-45-6789', 'Active', 'Boeing 787-800', 'Rome Airport'),
('Airbus A330', 'Airbus', 2015, '2023-01-01', 300, 7, 7, '234-56-7890', 'Active', 'Airbus A330-200', 'Paris Airport'),
('Bombardier CRJ900', 'Bombardier', 2016, '2023-01-01', 100, 8, 8, '345-67-8901', 'Active', 'Bombardier CRJ900-100', 'Dubai Airport'),
('Boeing 777', 'Boeing', 2017, '2023-01-01', 350, 9, 9, '456-78-9012', 'Active', 'Boeing 777-300', 'Berlin Airport'),
('Airbus A340', 'Airbus', 2018, '2023-01-01', 400, 10, 10, '567-89-0123', 'Inactive', 'Airbus A340-600', 'Seoul Airport'),
('Embraer E175', 'Embraer', 2019, '2023-01-01', 90, 11, 11, '123-45-6789', 'Active', 'Embraer E175-100', 'Reyad Airport'),
('Boeing 737', 'Boeing', 2015, '2023-01-01', 150, 12, 12, '234-56-7890', 'Active', 'Boeing 737-800', 'Cairo Airport'),
('Airbus A320', 'Airbus', 2018, '2023-01-01', 180, 13, 13, '345-67-8901', 'Active', 'Airbus A320-200', 'Giza Airport'),
('Boeing 747', 'Boeing', 2016, '2023-01-01', 300, 14, 14, '456-78-9012', 'Active', 'Boeing 747-400', 'London Airport'),
('Airbus A380', 'Airbus', 2017, '2023-01-01', 500, 15, 15, '567-89-0123', 'Inactive', 'Airbus A380-800', 'Toronto Airport'),
('Embraer E190', 'Embraer', 2019, '2023-01-01', 100, 16, 16, '123-45-6789', 'Active', 'Embraer E190-100', 'Sydney Airport'),
('Boeing 787', 'Boeing', 2014, '2023-01-01', 250, 17, 17, '234-56-7890', 'Active', 'Boeing 787-800', 'Rome Airport'),
('Airbus A330', 'Airbus', 2015, '2023-01-01', 300, 18, 18, '345-67-8901', 'Active', 'Airbus A330-200', 'Paris Airport'),
('Bombardier CRJ900', 'Bombardier', 2016, '2023-01-01', 100, 19, 19, '456-78-9012', 'Active', 'Bombardier CRJ900-100', 'Dubai Airport'),
('Boeing 777', 'Boeing', 2017, '2023-01-01', 350, 20, 20, '567-89-0123', 'Active', 'Boeing 777-300', 'Berlin Airport'),
('Airbus A340', 'Airbus', 2018, '2023-01-01', 400, 21, 19, '123-45-6789', 'Inactive', 'Airbus A340-600', 'Seoul Airport'),
('Embraer E175', 'Embraer', 2019, '2023-01-01', 90, 22, 15, '234-56-7890', 'Active', 'Embraer E175-100', 'Reyad Airport'),
('Boeing 737', 'Boeing', 2015, '2023-01-01', 150, 23, 13, '345-67-8901', 'Active', 'Boeing 737-800', 'Cairo Airport'),
('Airbus A320', 'Airbus', 2018, '2023-01-01', 180, 24, 14, '456-78-9012', 'Active', 'Airbus A320-200', 'Giza Airport'),
('Boeing 747', 'Boeing', 2016, '2023-01-01', 300, 25, 15, '567-89-0123', 'Active', 'Boeing 747-400', 'London Airport');