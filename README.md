# Mi Aplicación Web

Este proyecto es una aplicación web dinámica desarrollada con ASP .NET Core, Razor Pages y Entity Framework Core.

## Características

- Patrón de diseño MVC.
- Tres páginas Razor con contenido dinámico.
- Uso de directivas de control, bucles y condicionales en las vistas.
- Dos modelos de datos relacionados con el tema de la aplicación.
- Persistencia de datos con Entity Framework Core.
- Operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para los modelos definidos.
- Validación de las entradas del usuario y gestión de errores.
- Interfaz de usuario atractiva con estilos CSS.
- Diseño responsivo para adaptarse a diferentes tamaños de pantalla.

## Estructura del Proyecto

El proyecto sigue la estructura estándar de una aplicación ASP .NET Core MVC con las siguientes carpetas principales:

- `Controllers`: Contiene los controladores de la aplicación.
- `Models`: Contiene los modelos de datos de la aplicación.
- `Data`: Contiene la clase ApplicationDbContext que se utiliza para la persistencia de datos con Entity Framework Core.
- `Views`: Contiene las vistas Razor de la aplicación.
- `wwwroot`: Contiene los archivos estáticos de la aplicación como CSS, JavaScript y bibliotecas.

## Cómo Ejecutar

Para ejecutar esta aplicación, necesitarás tener instalado .NET Core. Luego, puedes clonar este repositorio y ejecutar el comando `dotnet run` en la raíz del proyecto.

