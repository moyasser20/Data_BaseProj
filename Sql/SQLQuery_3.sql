SELECT TOP (1000) [AIRPORTNAME]
      ,[CAPACITY]
      ,[LOCATION]
  FROM [FlightBookingSystemDatabase].[dbo].[AIRPORT]

INSERT INTO [FlightBookingSystemDatabase].[dbo].[AIRPORT] (AIRPORTNAME, CAPACITY, LOCATION)
VALUES 
    ('Cairo Airport', 1000 , 'Cairo'),
    ('Giza Airport', 500 , 'Giza'),
    ('London Airport', 2000 , 'Englang'),
    ('Toronto Airport', 1500 , 'Canada'),
    ('Sydney Airport', 2500 , 'Australia'),
    ('Rome Airport', 10000 , 'Italy'),
    ('Paris Airport', 5000 , 'France'),
    ('Dubai Airport', 12000 , 'UAE'),
    ('Berlin Airport', 6000 , 'Germany'),
    ('Seoul Airport', 4000 , 'South Korea'),
    ('Reyad Airport', 3000 , 'Saudi Arabia');

