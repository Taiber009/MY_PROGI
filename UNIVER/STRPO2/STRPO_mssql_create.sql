CREATE TABLE [Comics] (
	ID integer NOT NULL,
	Name varchar(255) NOT NULL,
	Series varchar(255),
	Publishing_house varchar(255),
	Written varchar,
	Released_Date date,
	Rating integer NOT NULL,
	Amount integer NOT NULL DEFAULT '0',
	Selling_price integer,
	Rental_price integer,
  CONSTRAINT [PK_COMICS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [User] (
	ID integer NOT NULL,
	Username varchar(255) NOT NULL UNIQUE,
	Pass varchar(255) NOT NULL,
	FIO varchar(255) NOT NULL,
	User_type integer NOT NULL DEFAULT '1',
	Email varchar(255) UNIQUE,
	Birthday date NOT NULL,
  CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [User_types] (
	Type_ID integer NOT NULL,
	Name varchar(255) NOT NULL UNIQUE,
  CONSTRAINT [PK_USER_TYPES] PRIMARY KEY CLUSTERED
  (
  [Type_ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Rating_system] (
	Rating_ID integer NOT NULL,
	Age integer NOT NULL UNIQUE,
  CONSTRAINT [PK_RATING_SYSTEM] PRIMARY KEY CLUSTERED
  (
  [Rating_ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Sold_Comics] (
	ID integer NOT NULL,
	ID_Comics integer NOT NULL,
	ID_User integer NOT NULL,
	Price integer NOT NULL,
	Sale_Date date NOT NULL,
  CONSTRAINT [PK_SOLD_COMICS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Rental_Comics] (
	ID integer NOT NULL,
	ID_Comics integer NOT NULL,
	ID_User integer NOT NULL,
	Price integer NOT NULL,
	Rental_date_start date NOT NULL,
	Rental_date_end date NOT NULL,
	Returned bit NOT NULL DEFAULT 'false',
  CONSTRAINT [PK_RENTAL_COMICS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO


ALTER TABLE [User_types] WITH CHECK ADD CONSTRAINT [User_types_fk0] FOREIGN KEY ([Type_ID]) REFERENCES [User]([User_type])
ON UPDATE CASCADE
GO
ALTER TABLE [User_types] CHECK CONSTRAINT [User_types_fk0]
GO

ALTER TABLE [Rating_system] WITH CHECK ADD CONSTRAINT [Rating_system_fk0] FOREIGN KEY ([Rating_ID]) REFERENCES [Comics]([Rating])
ON UPDATE CASCADE
GO
ALTER TABLE [Rating_system] CHECK CONSTRAINT [Rating_system_fk0]
GO

ALTER TABLE [Sold_Comics] WITH CHECK ADD CONSTRAINT [Sold_Comics_fk0] FOREIGN KEY ([ID_Comics]) REFERENCES [Comics]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Sold_Comics] CHECK CONSTRAINT [Sold_Comics_fk0]
GO
ALTER TABLE [Sold_Comics] WITH CHECK ADD CONSTRAINT [Sold_Comics_fk1] FOREIGN KEY ([ID_User]) REFERENCES [User]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Sold_Comics] CHECK CONSTRAINT [Sold_Comics_fk1]
GO

ALTER TABLE [Rental_Comics] WITH CHECK ADD CONSTRAINT [Rental_Comics_fk0] FOREIGN KEY ([ID_Comics]) REFERENCES [Comics]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Rental_Comics] CHECK CONSTRAINT [Rental_Comics_fk0]
GO
ALTER TABLE [Rental_Comics] WITH CHECK ADD CONSTRAINT [Rental_Comics_fk1] FOREIGN KEY ([ID_User]) REFERENCES [User]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Rental_Comics] CHECK CONSTRAINT [Rental_Comics_fk1]
GO
