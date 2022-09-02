# Tucson Project
Para comenzar la solución primero debe contar con la herramienta Visual Studio 2022 y Tener instalado AngularCli.
Una vez tenga ambos requerimientos, debe descargar el repositorio.
Cuando abra la solución de backend, antes de correr el projecto, se debé crear la base de datos. Para esto, ejecutar el comando "Update-Database" en 
la consola de manejador de paquetes.
Si la base se generó con éxito, se puede correr la solución, y esta misma generará algunos casos de uso.
Para ejecutar el frontEnd, se deberá ejectutar el comando "npm i", y luego el comando "ng serve"

Una vez corriendo ambas partes, las instrucciones de uso son las siguientes:
La pagina web mostrará una tabla de reservas, se han creado 37 de las 40 reservas posibles.
Esto para poder generar una Reserva a modo de prueba(con cada cantidad de cubiertos), y que la siguiente vez que se intente generar una reserva, está misma se cree en la lista de Espera.
Por ejemplo: Uno puede generar una reserva de 2 cubiertos, pero la siguiente vez que lo intente pasará a la tabla En Espera.
A su vez, si uno genera una reserva de 2 cubiertos, y una de 4, se generarán sin problema.
La lista de espera figura a la derecha de la pantalla.
La Tabla de Reserva cuenta con un botón de borrar, en caso de querer cancelar alguna reserva. (esto es un borrado logico, no fisico, ya que solo cambia de estado a "cancelado")
Si se borrá una reserva de determinada cantidad de cubiertos, y hay una reserva "en espera" de misma cantidad, automaticamete la reserva que estaba "en espera" pasará a "En curso" 

Luciano Gil