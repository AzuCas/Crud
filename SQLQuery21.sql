SELECT TOP (1000) [Id_Compras]
      ,[Id_clientes]
      ,[Código_producto]
  FROM [Actividad 3 Zapateria].[dbo].[Compras]


  alter table Compras
  add fecha_de_compra varchar(100);


  insert into Compras (Id_clientes, Código_producto, fecha_de_compra) values ('cava850329', '3',  '14/02/2023')