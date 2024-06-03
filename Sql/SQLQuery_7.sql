SELECT TOP (1000) [BOOKINGID]
      ,[SSN]
      ,[STATUS]
      ,[BOOKINGDATE]
      ,[PAYMENTMETHOD]
      ,[PRICE]
      ,[SEATNUMBER]
      ,[SEATCLASS]
  FROM [FlightBookingSystemDatabase].[dbo].[TICKET]
  
INSERT INTO [FlightBookingSystemDatabase].[dbo].[TICKET] 
([BOOKINGID], [SSN], [STATUS], [BOOKINGDATE], [PAYMENTMETHOD], [PRICE], [SEATNUMBER], [SEATCLASS])
VALUES
(140100, '123-45-6789', 'Confirmed', '2024-05-19', 'Credit Card', 250.00, 23, 'Economy'),
(140101, '234-56-7890', 'Pending', '2024-05-20', 'PayPal', 300.00, 12, 'Business'),
(140102, '345-67-8901', 'Confirmed', '2024-05-21', 'Credit Card', 200.00, 10, 'Economy'),
(140103, '456-78-9012', 'Pending', '2024-05-22', 'PayPal', 350.00, 5, 'Business'),
(140104, '567-89-0123', 'Confirmed', '2024-05-23', 'Credit Card', 275.00, 14, 'Economy'),
(140105, '678-90-1234', 'Pending', '2024-05-24', 'PayPal', 400.00, 20, 'Business'),
(140106, '789-01-2345', 'Confirmed', '2024-05-25', 'Credit Card', 225.00, 8, 'Economy'),
(140107, '890-12-3456', 'Pending', '2024-05-26', 'PayPal', 320.00, 3, 'Business'),
(140108, '901-23-4567', 'Confirmed', '2024-05-27', 'Credit Card', 260.00, 12, 'Economy'),
(140109, '012-34-5678', 'Pending', '2024-05-28', 'PayPal', 380.00, 7, 'Business'),
(140110, '112-45-6789', 'Confirmed', '2024-05-29', 'Credit Card', 240.00, 15, 'Economy'),
(140111, '212-56-7890', 'Pending', '2024-05-30', 'PayPal', 370.00, 9, 'Business'),
(140112, '312-67-8901', 'Confirmed', '2024-05-31', 'Credit Card', 280.00, 18, 'Economy'),
(140113, '412-78-9012', 'Pending', '2024-06-01', 'PayPal', 390.00, 4, 'Business'),
(140114, '512-89-0123', 'Confirmed', '2024-06-02', 'Credit Card', 255.00, 22, 'Economy'),
(140115, '612-90-1234', 'Pending', '2024-06-03', 'PayPal', 360.00, 11, 'Business'),
(140116, '712-01-2345', 'Confirmed', '2024-06-04', 'Credit Card', 270.00, 17, 'Economy'),
(140117, '812-12-3456', 'Pending', '2024-06-05', 'PayPal', 400.00, 6, 'Business'),
(140118, '912-23-4567', 'Confirmed', '2024-06-06', 'Credit Card', 285.00, 13, 'Economy'),
(140119, '013-34-5678', 'Pending', '2024-06-07', 'PayPal', 380.00, 2, 'Business'),
(140120, '123-45-6789', 'Confirmed', '2024-06-08', 'Credit Card', 295.00, 19, 'Economy'),
(140121, '234-56-7890', 'Pending', '2024-06-09', 'PayPal', 410.00, 8, 'Business'),
(140122, '345-67-8901', 'Confirmed', '2024-06-10', 'Credit Card', 300.00, 16, 'Economy'),
(140123, '456-78-9012', 'Pending', '2024-06-11', 'PayPal', 420.00, 1, 'Business'),
(140124, '567-89-0123', 'Confirmed', '2024-06-12', 'Credit Card', 305.00, 21, 'Economy'),
(140125, '678-90-1234', 'Pending', '2024-06-13', 'PayPal', 430.00, 10, 'Business'),
(140126, '789-01-2345', 'Confirmed', '2024-06-14', 'Credit Card', 310.00, 14, 'Economy'),
(140127, '890-12-3456', 'Pending', '2024-06-15', 'PayPal', 440.00, 3, 'Business'),
(140128, '901-23-4567', 'Confirmed', '2024-06-16', 'Credit Card', 315.00, 20, 'Economy'),
(140129, '012-34-5678', 'Pending', '2024-06-17', 'PayPal', 450.00, 11, 'Business'),
(140130, '112-45-6789', 'Confirmed', '2024-06-18', 'Credit Card', 320.00, 17, 'Economy'),
(140131, '212-56-7890', 'Pending', '2024-06-19', 'PayPal', 460.00, 6, 'Business'),
(140132, '312-67-8901', 'Confirmed', '2024-06-20', 'Credit Card', 325.00, 13, 'Economy'),
(140133, '412-78-9012', 'Pending', '2024-06-21', 'PayPal', 470.00, 22, 'Business'),
(140134, '512-89-0123', 'Confirmed', '2024-06-22', 'Credit Card', 330.00, 9, 'Economy'),
(140135, '612-90-1234', 'Pending', '2024-06-23', 'PayPal', 480.00, 16, 'Business'),
(140136, '712-01-2345', 'Confirmed', '2024-06-24', 'Credit Card', 335.00, 5, 'Economy');
