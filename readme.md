# Aplicación ASP.NET Core
Esta es una muestra de una aplicación ASP.NET Core que demuestra cómo implementar operaciones CRUD para un catálogo de personas API utilizando el patrón Clean Architecture.

## Requisitos previos

- .NET Core SDK
- MySQL Server
- Visual Studio Code o Visual Studio (opcional)


## Empezando
Siga estos pasos para ejecutar la aplicación:

1. Clona el repositorio en tu máquina local.
2. Navega al directorio del proyecto.
3. Actualiza la cadena de conexión de la base de datos en el archivo `appsettings.json`.
4. Aplica las migraciones para crear el esquema de la base de datos.
5. Ejecuta la aplicación.
6. Accede a la API utilizando un navegador web.

## Información Adicional
- La aplicación utiliza Entity Framework Core para el acceso a datos y MySQL como el proveedor de base de datos.
- Se implementa Swagger para proporcionar documentación de la API y capacidades de prueba. Al correr el Proyecto con dotnet run, puedes acceder por medio de http://localhost:5252/swagger/index.html
- Se sigue el patrón Clean Architecture para mantener la separación de preocupaciones y mejorar la escalabilidad y mantenibilidad.

## Soporte
Para cualquier problema o pregunta, por favor abre un issue en el repositorio de GitHub o contacta a [Paulo Ismalej](mailto:paulo.ismalej@gmail.com).

