SELECT TOP (1000) [dni]
      ,[Nombre]
      ,[Apellidos]
      ,[Fecha_de_nacimiento]
      ,[Teléfono]
  FROM [Actividad 3 Zapateria].[dbo].[Clientes]


  update Clientes set Nombre = '' where dni = 'cava850329'

  delete from Clientes where dni = 