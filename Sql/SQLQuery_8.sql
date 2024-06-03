SELECT TOP (1000) [FNAME]
      ,[LNAME]
      ,[AGE]
      ,[EMAIL]
      ,[PASSWORD]
      ,[BDAY]
      ,[BMONTH]
      ,[BYEAR]
      ,[USERNAME]
      ,[SSN]
  FROM [FlightBookingSystemDatabase].[dbo].[USER]

ALTER TABLE [FlightBookingSystemDatabase].[dbo].[USER]
ALTER COLUMN [LNAME] VARCHAR(100); -- Assuming a maximum length of 100 characters, adjust as needed

INSERT INTO [FlightBookingSystemDatabase].[dbo].[USER]
([FNAME], [LNAME], [AGE], [EMAIL], [PASSWORD], [BDAY], [BMONTH], [BYEAR], [USERNAME], [SSN])
VALUES
-- Generating 50 rows of data for users
('John', 'Doe', 25, 'john.doe@example.com', 'password1', 5, 8, 1995, 'johndoe', '123-45-6789'),
('Alice', 'Smith', 30, 'alice.smith@example.com', 'password2', 12, 4, 1990, 'alicesmith', '234-56-7890'),
('Michael', 'Johnson', 28, 'michael.johnson@example.com', 'password3', 15, 11, 1992, 'michaeljohnson', '345-67-8901'),
('Emily', 'Brown', 22, 'emily.brown@example.com', 'password4', 9, 6, 1998, 'emilybrown', '456-78-9012'),
('William', 'Davis', 35, 'william.davis@example.com', 'password5', 21, 9, 1985, 'williamdavis', '567-89-0123'),
('Emma', 'Martinez', 27, 'emma.martinez@example.com', 'password6', 18, 3, 1993, 'emmartinez', '678-90-1234'),
('James', 'Garcia', 29, 'james.garcia@example.com', 'password7', 14, 7, 1991, 'jamesgarcia', '789-01-2345'),
('Olivia', 'Wilson', 31, 'olivia.wilson@example.com', 'password8', 26, 12, 1989, 'oliviawilson', '890-12-3456'),
('Benjamin', 'Taylor', 26, 'benjamin.taylor@example.com', 'password9', 3, 10, 1994, 'benjamintaylor', '901-23-4567'),
('Sophia', 'Anderson', 24, 'sophia.anderson@example.com', 'password10', 17, 2, 1996, 'sophiaanderson', '012-34-5678'),
('Ethan', 'Clark', 28, 'ethan.clark@example.com', 'password11', 7, 5, 1992, 'ethanclark', '112-45-6789'),
('Madison', 'White', 32, 'madison.white@example.com', 'password12', 25, 8, 1988, 'madisonwhite', '212-56-7890'),
('Alexander', 'Hill', 29, 'alexander.hill@example.com', 'password13', 11, 1, 1991, 'alexanderhill', '312-67-8901'),
('Chloe', 'Martin', 23, 'chloe.martin@example.com', 'password14', 8, 9, 1997, 'chloemartin', '412-78-9012'),
('Daniel', 'Jackson', 36, 'daniel.jackson@example.com', 'password15', 2, 11, 1984, 'danieljackson', '512-89-0123'),
('Ava', 'Lewis', 28, 'ava.lewis@example.com', 'password16', 19, 4, 1992, 'avalewis', '612-90-1234'),
('Matthew', 'Lee', 30, 'matthew.lee@example.com', 'password17', 13, 6, 1990, 'matthewlee', '712-01-2345'),
('Avery', 'Walker', 25, 'avery.walker@example.com', 'password18', 5, 3, 1995, 'averywalker', '812-12-3456'),
('Sofia', 'Hall', 27, 'sofia.hall@example.com', 'password19', 27, 9, 1993, 'sofiahall', '912-23-4567'),
('Jackson', 'Young', 33, 'jackson.young@example.com', 'password20', 16, 7, 1987, 'jacksonyoung', '013-34-5678');
