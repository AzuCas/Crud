Create table Clientes
(
Id varchar(100) primary key not null,
Nombre varchar(100) not null, 
Apellidos varchar (100) not null, 
Fecha_de_nacimiento varchar (100) not null, 
Teléfono bigint not null, 
)

Create table Compras
(
Id_Compras int primary key identity not null,
Id_clientes varchar(100) not null,
Código_producto int not null,
)