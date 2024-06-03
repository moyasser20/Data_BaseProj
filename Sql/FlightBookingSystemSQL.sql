/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/15/2024 2:15:44 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AIRCRAFT') and o.name = 'FK_AIRCRAFT_CONTAINS_AIRPORT')
alter table AIRCRAFT
   drop constraint FK_AIRCRAFT_CONTAINS_AIRPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AIRCRAFT') and o.name = 'FK_AIRCRAFT_MANAGES_ADMIN')
alter table AIRCRAFT
   drop constraint FK_AIRCRAFT_MANAGES_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AIRCRAFT') and o.name = 'FK_AIRCRAFT_SERVICED__FLIGHT')
alter table AIRCRAFT
   drop constraint FK_AIRCRAFT_SERVICED__FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKED_FLIGHT') and o.name = 'FK_BOOKED_F_BOOKED_FL_TICKET')
alter table BOOKED_FLIGHT
   drop constraint FK_BOOKED_F_BOOKED_FL_TICKET
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKED_FLIGHT') and o.name = 'FK_BOOKED_F_BOOKED_FL_FLIGHT')
alter table BOOKED_FLIGHT
   drop constraint FK_BOOKED_F_BOOKED_FL_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_CHANGE_ST_ADMIN')
alter table FLIGHT
   drop constraint FK_FLIGHT_CHANGE_ST_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_FLIES_TO_AIRPORT')
alter table FLIGHT
   drop constraint FK_FLIGHT_FLIES_TO_AIRPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LUGGAGE') and o.name = 'FK_LUGGAGE_HAS_USER')
alter table LUGGAGE
   drop constraint FK_LUGGAGE_HAS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TICKET') and o.name = 'FK_TICKET_BOOKS_USER')
alter table TICKET
   drop constraint FK_TICKET_BOOKS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USER_PHONENUMBER') and o.name = 'FK_USER_PHO_HAS_A_USER')
alter table USER_PHONENUMBER
   drop constraint FK_USER_PHO_HAS_A_USER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AIRCRAFT')
            and   name  = 'SERVICED_BY_FK'
            and   indid > 0
            and   indid < 255)
   drop index AIRCRAFT.SERVICED_BY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AIRCRAFT')
            and   name  = 'CONTAINS_FK'
            and   indid > 0
            and   indid < 255)
   drop index AIRCRAFT.CONTAINS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AIRCRAFT')
            and   name  = 'MANAGES_FK'
            and   indid > 0
            and   indid < 255)
   drop index AIRCRAFT.MANAGES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCRAFT')
            and   type = 'U')
   drop table AIRCRAFT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRPORT')
            and   type = 'U')
   drop table AIRPORT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKED_FLIGHT')
            and   name  = 'BOOKED_FLIGHT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKED_FLIGHT.BOOKED_FLIGHT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKED_FLIGHT')
            and   name  = 'BOOKED_FLIGHT_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKED_FLIGHT.BOOKED_FLIGHT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKED_FLIGHT')
            and   type = 'U')
   drop table BOOKED_FLIGHT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHT')
            and   name  = 'FLIES_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHT.FLIES_TO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHT')
            and   name  = 'CHANGE_STATUS_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHT.CHANGE_STATUS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHT')
            and   type = 'U')
   drop table FLIGHT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LUGGAGE')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LUGGAGE.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LUGGAGE')
            and   type = 'U')
   drop table LUGGAGE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'BOOKS_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.BOOKS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TICKET')
            and   type = 'U')
   drop table TICKET
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USER_PHONENUMBER')
            and   name  = 'HAS_A_FK'
            and   indid > 0
            and   indid < 255)
   drop index USER_PHONENUMBER.HAS_A_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USER_PHONENUMBER')
            and   type = 'U')
   drop table USER_PHONENUMBER
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   USERNAME             varchar(100)         not null,
   EMAIL                varchar(100)         not null,
   PASSWORD             varchar(100)         not null,
   ADMIN_SSN            varchar(100)         not null,
   PHONENUMBERR         varchar(100)         not null,
   constraint PK_ADMIN primary key nonclustered (ADMIN_SSN)
)
go

/*==============================================================*/
/* Table: AIRCRAFT                                              */
/*==============================================================*/
create table AIRCRAFT (
   MODEL                varchar(100)         not null,
   MANUDACTURE          varchar(100)         not null,
   YEAROFMANUFACTURE    int                  not null,
   LASTMAINTENACEDATE   datetime             not null,
   CAPACITY             int                  not null,
   AIRCRAFTID           int                  not null,
   FLIGHT_ID            int                  null,
   ADMIN_SSN            varchar(100)         not null,
   STATUS               varchar(100)         not null,
   AIRCRAFTNAME         varchar(100)         not null,
   AIRPORTNAME          varchar(100)         null,
   constraint PK_AIRCRAFT primary key nonclustered (AIRCRAFTID)
)
go

/*==============================================================*/
/* Index: MANAGES_FK                                            */
/*==============================================================*/
create index MANAGES_FK on AIRCRAFT (
ADMIN_SSN ASC
)
go

/*==============================================================*/
/* Index: CONTAINS_FK                                           */
/*==============================================================*/
create index CONTAINS_FK on AIRCRAFT (
AIRPORTNAME ASC
)
go

/*==============================================================*/
/* Index: SERVICED_BY_FK                                        */
/*==============================================================*/
create index SERVICED_BY_FK on AIRCRAFT (
FLIGHT_ID ASC
)
go

/*==============================================================*/
/* Table: AIRPORT                                               */
/*==============================================================*/
create table AIRPORT (
   AIRPORTNAME          varchar(100)         not null,
   CAPACITY             int                  null,
   LOCATION             varchar(100)         null,
   constraint PK_AIRPORT primary key (AIRPORTNAME)
)
go

/*==============================================================*/
/* Table: BOOKED_FLIGHT                                         */
/*==============================================================*/
create table BOOKED_FLIGHT (
   TIC_BOOKINGID        int                  not null,
   FLIGHT_ID            int                  not null,
   BOOKINGID            int                  not null,
   FLIGHTID             int                  not null,
   DATE                 datetime             not null,
   constraint PK_BOOKED_FLIGHT primary key (TIC_BOOKINGID, FLIGHT_ID)
)
go

/*==============================================================*/
/* Index: BOOKED_FLIGHT_FK                                      */
/*==============================================================*/
create index BOOKED_FLIGHT_FK on BOOKED_FLIGHT (
TIC_BOOKINGID ASC
)
go

/*==============================================================*/
/* Index: BOOKED_FLIGHT2_FK                                     */
/*==============================================================*/
create index BOOKED_FLIGHT2_FK on BOOKED_FLIGHT (
FLIGHT_ID ASC
)
go

/*==============================================================*/
/* Table: FLIGHT                                                */
/*==============================================================*/
create table FLIGHT (
   DEPARTUREDATETIME    datetime             not null,
   DESTINATIONAIRPORTNAME varchar(100)         not null,
   ARRIVALDATETIME      datetime             not null,
   STATUS               varchar(100)         not null,
   AVAILABLESEATS       int                  not null,
   ORIGINAIRPORTNAME    varchar(100)         not null,
   FLIGHT_ID            int                  not null,
   ADMIN_SSN            varchar(100)         not null,
   AIRPORTNAME          varchar(100)         null,
   constraint PK_FLIGHT primary key nonclustered (FLIGHT_ID)
)
go

/*==============================================================*/
/* Index: CHANGE_STATUS_FK                                      */
/*==============================================================*/
create index CHANGE_STATUS_FK on FLIGHT (
ADMIN_SSN ASC
)
go

/*==============================================================*/
/* Index: FLIES_TO_FK                                           */
/*==============================================================*/
create index FLIES_TO_FK on FLIGHT (
AIRPORTNAME ASC
)
go

/*==============================================================*/
/* Table: LUGGAGE                                               */
/*==============================================================*/
create table LUGGAGE (
   BAGGAGEID            int                  not null,
   SSN                  varchar(100)         null,
   WEIGHT               float(50)            not null,
   AIRCRAFT             int                  not null,
   constraint PK_LUGGAGE primary key nonclustered (BAGGAGEID)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on LUGGAGE (
SSN ASC
)
go

/*==============================================================*/
/* Table: TICKET                                                */
/*==============================================================*/
create table TICKET (
   BOOKINGID            int                  not null,
   SSN                  varchar(100)         not null,
   STATUS               varchar(100)         not null,
   BOOKINGDATE          datetime             not null,
   PAYMENTMETHOD        varchar(100)         not null,
   PRICE                int                  not null,
   SEATNUMBER           int                  not null,
   SEATCLASS            varchar(100)         not null,
   constraint PK_TICKET primary key nonclustered (BOOKINGID)
)
go

/*==============================================================*/
/* Index: BOOKS_FK                                              */
/*==============================================================*/
create index BOOKS_FK on TICKET (
SSN ASC
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   FNAME                varchar(100)         not null,
   LNAME                int                  not null,
   PHONENUMBER          varchar(100)         not null,
   AGE                  int                  not null,
   EMAIL                varchar(100)         not null,
   PASSWORD             varchar(100)         not null,
   BDAY                 varchar(100)         not null,
   BMONTH               varchar(100)         not null,
   BYEAR                varchar(100)         not null,
   USERNAME             varchar(100)         not null,
   SSN                  varchar(100)         not null,
   constraint PK_USER primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Table: USER_PHONENUMBER                                      */
/*==============================================================*/
create table USER_PHONENUMBER (
   USER_SSN             varchar(100)         not null,
   COUNTRYCODE          int                  not null,
   NUMBER               varchar(100)         not null,
   SSN                  varchar(100)         null,
   constraint PK_USER_PHONENUMBER primary key nonclustered (NUMBER, USER_SSN, COUNTRYCODE)
)
go

/*==============================================================*/
/* Index: HAS_A_FK                                              */
/*==============================================================*/
create index HAS_A_FK on USER_PHONENUMBER (
SSN ASC
)
go

alter table AIRCRAFT
   add constraint FK_AIRCRAFT_CONTAINS_AIRPORT foreign key (AIRPORTNAME)
      references AIRPORT (AIRPORTNAME)
go

alter table AIRCRAFT
   add constraint FK_AIRCRAFT_MANAGES_ADMIN foreign key (ADMIN_SSN)
      references ADMIN (ADMIN_SSN)
go

alter table AIRCRAFT
   add constraint FK_AIRCRAFT_SERVICED__FLIGHT foreign key (FLIGHT_ID)
      references FLIGHT (FLIGHT_ID)
go

alter table BOOKED_FLIGHT
   add constraint FK_BOOKED_F_BOOKED_FL_TICKET foreign key (TIC_BOOKINGID)
      references TICKET (BOOKINGID)
go

alter table BOOKED_FLIGHT
   add constraint FK_BOOKED_F_BOOKED_FL_FLIGHT foreign key (FLIGHT_ID)
      references FLIGHT (FLIGHT_ID)
go

alter table FLIGHT
   add constraint FK_FLIGHT_CHANGE_ST_ADMIN foreign key (ADMIN_SSN)
      references ADMIN (ADMIN_SSN)
go

alter table FLIGHT
   add constraint FK_FLIGHT_FLIES_TO_AIRPORT foreign key (AIRPORTNAME)
      references AIRPORT (AIRPORTNAME)
go

alter table LUGGAGE
   add constraint FK_LUGGAGE_HAS_USER foreign key (SSN)
      references "USER" (SSN)
go

alter table TICKET
   add constraint FK_TICKET_BOOKS_USER foreign key (SSN)
      references "USER" (SSN)
go

alter table USER_PHONENUMBER
   add constraint FK_USER_PHO_HAS_A_USER foreign key (SSN)
      references "USER" (SSN)
go

