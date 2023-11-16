# blog-app-test

Proyecto que muestra y permite dar de alta entradas de un blog

## Requisitos del Sistema
- .NET Core SDK
- Visual Studio 2022 Community

## Configuraci�n del proyecto
1. Clona este repositorio.
2. Abre el repositorio en Visual Studio 2022.
3. Define la cadena de conexi�n en los settings del proyecto "blog-app-test-api"
- La cadena de conexi�n se debe configurar en la secci�n "ConnectionStrings:BlogAppTestDbContextConnection"
4. Recompila la soluci�n.
5. Accede a la ventana PackageManagerConsole. Puedes acceder desde el menu View\OtherWindows.
- Establece el proyecto "blog-app-test-api" como proyecto de inicio.
- En la ventana establece el valor para "Default project" en "blog-app-test-api"
- Ejecuta el comando "update-database".
6. Define la URL base del API con el que se conectar� la aplicacion MVC. Esto lo podr�s realizar en los settings del proyecto "blog-app-test".
7. Establece ambos proyectos como proyectos de inicio
-  Esto lo puedes realizar dando click derecho sobre la soluci�n y seleccionando la opci�n "Configure Startup Projects".

## Estructura del proyecto
La soluci�n est� compuesta por dos proyectos creados con el framework .NET Core 6
- blog-app-test-api: Rest API con acceso a la base de datos y endpoints para lectura y escritura de datos
- blog-app-test: Interfaz de usuario con ASP MVC.

## Tecnologias utilizadas
- .NET Core 6
- ASP MVC
- Web API
- Bootstrap
- JQUERY
- Entity Core
- Swagger

## Notas
- No se ha implementado autenticaci�n por lo que se tiene que definir el nombre de quien esta dando de alta un articulo en el blog
- Se trat� de evitar en lo mas posible utilizar JQUERY para mantener el codigo lo mas limpio posible

## Contacto 
- Carlos Aguilar
- Tel: 921-200-7848
- Email: caos_8910@yahoo.com.mx