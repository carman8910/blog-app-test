# blog-app-test

Proyecto que muestra y permite dar de alta entradas de un blog

## Requisitos del Sistema
- .NET Core SDK
- Visual Studio 2022 Community

## Configuración del proyecto
1. Clona este repositorio.
2. Abre el repositorio en Visual Studio 2022.
3. Define la cadena de conexión en los settings del proyecto "blog-app-test-api"
3.1. La cadena de conexión se debe configurar en la sección "ConnectionStrings:BlogAppTestDbContextConnection"
4. Recompila la solución.
5. Accede a la ventana PackageManagerConsole. Puedes acceder desde el menu View\OtherWindows.
5.1. Establece el proyecto "blog-app-test-api" como proyecto de inicio.
5.2. En la ventana establece el valor para "Default project" en "blog-app-test-api"
5.3. Ejecuta el comando "update-database".
6. Define la URL base del API con el que se conectará la aplicacion MVC. Esto lo podrás realizar en los settings del proyecto "blog-app-test".
7. Establece ambos proyectos como proyectos de inicio
7.1. Esto lo puedes realizar dando click derecho sobre la solución y seleccionando la opción "Configure Startup Projects".

## Estructura del proyecto
La solución está compuesta por dos proyectos creados con el framework .NET Core 6
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
- No se ha implementado autenticación por lo que se tiene que definir el nombre de quien esta dando de alta un articulo en el blog
- Se trató de evitar en lo mas posible utilizar JQUERY para mantener el codigo lo mas limpio posible

## Contacto 
Carlos Aguilar
Tel: 921-200-7848
Email: caos_8910@yahoo.com.mx