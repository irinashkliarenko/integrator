--src db
CREATE DATABASE _SOURCE;

CREATE TABLE _ADDRESS(
COUNTRY VARCHAR (20) NOT NULL,
CITY VARCHAR (20) NOT NULL
)

CREATE TABLE _USER(
NAME VARCHAR (20) NOT NULL,
SURNAME VARCHAR (20) NOT NULL,
AGE INT
);

insert into _ADDRESS values ('Polska', 'Krakow')
insert into _ADDRESS values ('Polska', 'Warszawa')
insert into _ADDRESS values ('Polska', 'Gdansk')
insert into _ADDRESS values ('Polska', 'Gdynia')
insert into _ADDRESS values ('Polska', 'Katowice')
insert into _ADDRESS values ('Polska', 'Lublin')
insert into _ADDRESS values ('Rosja', 'Ekaterinburg')
insert into _ADDRESS values ('Rosja', 'Moskwa')
insert into _ADDRESS values ('Rosja', 'Omsk')
insert into _ADDRESS values ('Rosja', 'Samara')
insert into _ADDRESS values ('Rosja', 'Irkutsk')

insert into _USER values ('Kazimierz', 'Górski', 32)
insert into _USER values ('Zofia', 'Bąk', 23)
insert into _USER values ('Sylwia', 'Kaźmierczak', 22)
insert into _USER values ('Jadwiga', 'Brzezińska', 44)
insert into _USER values ('Ewa', 'Duda', 52)
insert into _USER values ('Agata', 'Agata', 63)
insert into _USER values ('Adam', 'Jankowski', 42)
insert into _USER values ('Jacek', 'Laskowski', 25)
insert into _USER values ('Mieczysław', 'Zając', 31)
insert into _USER values ('Dorota', 'Maciejewska', 27)

--target db
CREATE DATABASE _TARGET;

CREATE TABLE _ADDRESS(
COUNTRY VARCHAR (20) NOT NULL,
CITY VARCHAR (20) NOT NULL
)

CREATE TABLE _USER(
NAME VARCHAR (20) NOT NULL,
SURNAME VARCHAR (20) NOT NULL,
AGE INT
);

insert into _ADDRESS values ('Polska', 'Lodz')
insert into _ADDRESS values ('Polska', 'Warszawa')
insert into _ADDRESS values ('Polska', 'Gdansk')
insert into _ADDRESS values ('Polska', 'Szczecin')
insert into _ADDRESS values ('Polska', 'Wroclaw')
insert into _ADDRESS values ('Polska', 'Lublin')
insert into _ADDRESS values ('Rosja', 'St. Petersburg')
insert into _ADDRESS values ('Rosja', 'Moskwa')
insert into _ADDRESS values ('Rosja', 'Togliatti')
insert into _ADDRESS values ('Rosja', 'Samara')
insert into _ADDRESS values ('Rosja', 'Kazan')

insert into _USER values ('Kazimierz', 'Górski', 32)
insert into _USER values ('Henryk', 'Bąk', 23)
insert into _USER values ('Marian', 'Chmielewski', 22)
insert into _USER values ('Jadwiga', 'Brzezińska', 44)
insert into _USER values ('Ewa', 'Duda', 52)
insert into _USER values ('Małgorzata', 'Jaworska', 63)
insert into _USER values ('Joanna', 'Baranowska', 42)
insert into _USER values ('Grażyna', 'Górska', 25)
insert into _USER values ('Mieczysław', 'Zając', 31)
insert into _USER values ('Wiesław', 'Przybylski', 27)

