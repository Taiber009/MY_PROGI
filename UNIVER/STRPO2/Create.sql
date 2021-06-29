
-- �������� �������
DROP TABLE IF EXISTS dbo.Company;
-- ��������
DROP TABLE IF EXISTS dbo.Vacancy;
-- ������ ��������
DROP TABLE IF EXISTS dbo.CompanySize;
-- ��� ��������
DROP TABLE IF EXISTS dbo.CompanyType;
-- ����� ��� ������
DROP TABLE IF EXISTS dbo.[Login];


create table [Login] (
	ID int primary key identity (1,1),
		-- ������������ ��������
	Username varchar(50) not null unique,
		-- �� ������ �����
	Pass varchar(100) not null,
);
	-- ��� ��� Pa$$w0rd
insert into [Login] values ('admin', 'SVNNdktYcFhwYWREaVVvTzpzIdnCQZ4ak4ACsEVFSpf7m/B/');


create table CompanyType (
	ID int primary key identity (1,1),
	[Type] varchar(15) not null,
);

insert into CompanyType values ('���');
insert into CompanyType values ('��');
insert into CompanyType values ('���');
insert into CompanyType values ('��');
insert into CompanyType values ('���');
insert into CompanyType values ('�����. ���.');
insert into CompanyType values ('���. ���.');
insert into CompanyType values ('����');
insert into CompanyType values ('���. ����.');
insert into CompanyType values ('��');
insert into CompanyType values ('���');
insert into CompanyType values ('���');
insert into CompanyType values ('������');


create table CompanySize (
	ID int primary key identity (1,1),
	[Size] varchar(30) not null,
);
insert into CompanySize values ('����� 50 �����������');
insert into CompanySize values ('�� 51 �� 100 �����������');
insert into CompanySize values ('�� 101 �� 250 �����������');
insert into CompanySize values ('�� 251 �� 500 �����������');
insert into CompanySize values ('����� 500 �����������');


create table Company (
	ID int primary key identity (1,1),
	LoginID int not null,
	constraint FK_Company_Logins foreign key (LoginID) references [Login] (ID)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
		-- �� ��������
	ShowName varchar(50) not null unique,
		-- ��� ��������
	CompanyTypeID int not null,
	constraint FK_Company_CompanyType foreign key (CompanyTypeID) references CompanyType (ID)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
		-- ������ ��������
	CompanySizeID int not null,
	constraint FK_Company_CompanySize foreign key (CompanySizeID) references CompanySize (ID)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
		-- �����-�� ���� ���� �������
	City varchar(30) not null,
	ContactEmail varchar(50) not null,
	ContactPhone varchar(15) not null,
);

	-- �����, ����� ���������
create table Vacancy (
	ID int primary key identity (1,1),
	CompanyID int not null,
	constraint FK_Vacancy_Company foreign key (CompanyID) references Company (ID)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	Title varchar(100) not null,
	[Description] varchar(max) not null
);