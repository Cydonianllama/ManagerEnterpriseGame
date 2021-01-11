/*
create table positionWork(
	idPosition int not null primary key auto_increment,
    name_ varchar(40) not null
);
insert into positionWork(name_) values('ticketholder');
insert into positionWork(name_) values('security');

create table sectors(
	idSector int not null primary key auto_increment,
    nameSector varchar(40) not null
);
insert into sectors(nameSector) values('sector-a0');
insert into sectors(nameSector) values('sector-a1');
insert into sectors(nameSector) values('sector-a2');
insert into sectors(nameSector) values('sector-b0');
insert into sectors(nameSector) values('sector-b1');

create table clients(
	idClient int not null primary key auto_increment
);

create table tickets(
	idTicket int not null primary key auto_increment,
    idClient int not null,
    emissionDate date not null,
    expirationDate date not null,
    foreign key(idClient) references clients(idClient)
);

create table worker(
	idWorker int not null primary key auto_increment,
	idPosition int not null,
    idSectorWork int not null,
    foreign key(idPosition) references positionWork(idPosition),
    foreign key(idSectorWork) references sectors(idSector)
);

create table informationPerson(
	idInfo int not null primary key auto_increment,
    idClient int default null,
    idWorker int default null,
    fullname varchar(40),
    birthdate date default null,
    typeIdentification varchar(20),
    codeIdentification varchar(40),
    foreign key(idClient) references clients(idClient),
    foreign key(idWorker) references worker(idWorker)
);

*/