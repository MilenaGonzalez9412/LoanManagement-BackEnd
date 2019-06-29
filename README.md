# Loan Management Backend

Para iniciar el Backend, es necesario descargar el repositorio en la máquina y tener descargado Visual Studio y SQL server. Abrir la solución y desde allí buscar el archivo con nombre Web.config. Ahí se encuentra un bloque de código con nombre 'connectionStrings' (lo que permitirá iniciar la conexión con la base de datos), se deben modificar las siguientes variables:
    *connectionString=
        Server=localhost\SQLEXPRESS => Se coloca el nombre del servidor en el cual se está trabajando o el local. 
        database=dbPropertyInventory => se coloca el nombre de la base de datos que se va a crear en SQL server.
        user id=user;password=pass => Si el motor de base de datos requiere autenticación, en esta parte se coloca el id y la contraseña correspondientes para iniciar la conexión. Si no requiere autenticación, eliminar estas variables.

En SQL server, luego de realizar la conexión se debe crear una base de datos con el nombre 'LoanManagement'

Luego, volver a Visual Studio y abrir el Administrador de Paquetes y correr los siguientes comandos:
    1. Install-Package EntityFramework -Version 6.2.0
    2. Enable-Migrations
    3. Add-Migration Initial
    4. Update-Database

Finalmente, presionar la tecla F5 lo que abrirá el navegador. Luego continuar con el proceso de FrontEnd