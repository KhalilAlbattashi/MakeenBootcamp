CREATE TABLE Airline(
	AirlineID int primary key identity(1,1),
	Name varchar(60) not null,
	email varchar(100) not null,
	phone varchar(10) not null,
	Representative varchar(60) not null
);
CREATE TABLE Flight(
	FlightID int primary key identity(1,1),
	Airline_ID int foreign key references Airline(AirlineID),
	GateNumber int not null,
	DestinationCity varchar(40) not null,
	DepartureCity varchar(40) not null,
	DepartureTime varchar(10) not null,
	ArrivalTime varchar(10) not null,
	FlightStatus varchar(10) not null
);
CREATE TABLE Passenger(
	Pnumber int primary key,
	Flight_ID int foreign key references Flight(FlightID),
	Fname varchar(20) not null,
	Lname varchar(20) not null,
	Gender varchar(1) not null,
	DoB date not null,
	Pemail varchar(100) not null,
	Pphone varchar(10) not null,
	Nationality varchar(20) not null
);
CREATE TABLE Baggage(
	BaggageID int primary key,
	Passenger_ID int foreign key references Passenger(Pnumber),
	weight int not null,
	TrackingNumber int not null,
);
CREATE TABLE SecurityCheckpoint(
	CheckpointID int primary key identity(1,1),
	TerminalID int not null,
	CheckpointName varchar(20) not null,
	Tname varchar(20) not null,
	Tlocation varchar(20) not null,
	Tcapacity int not null
);
CREATE TABLE Officer(
	officerID int primary key identity(1,1),
	cID int foreign key references SecurityCheckpoint(CheckpointID),
	Officer_fname varchar(20) not null,
	Officer_lname varchar(20) not null,
	Department varchar(20) not null,
	Position varchar(20) not null,
);
