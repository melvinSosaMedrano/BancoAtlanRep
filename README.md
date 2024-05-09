# BancoAtlanRep
 Repositorio de entrega de prueba practica Banco Atlantida

El proyecto incluye dos principales aplicaciones:

API en ASP.NET Core 6: Proporciona los endpoints necesarios para gestionar las transacciones y consultas a clientes.

--CONSIDERACIONES


Por motivos de tiempos laborales no pude implementar la tecnologia RAZOR, por lo cual para practicidad del ejercicio lo realice en .NET FRAMEWORK WINDOWS FORMS,
Poseo conocimientos solidos en NodeJs + Vue con Vuetify y debido a la complejidad para que el equipo Atlantida puedieran ejecutar el aplicativo con esta tecnologia opte por una opcion de 
Interfaz mas sencilla para la practica. 
Aplicación WINDOWS FORMS .NET FRAMEWORK MVC: Interfaz de usuario para interactuar con el sistema de gestión de tarjetas de crédito.

# Se adjunta manual de uso del aplicativo.
Manual de usuario, Melvin Sosa.pdf

# Requisitos para Ejecucion del proyecto

- Visual Studio 2019
- .NET Core 7.0 SDK
- SQL Server
- SQL Management Studio
- Postman
  
**ADVERTENCIA** Se deberan ejecutar ambas aplicaciones VistaAtlan y AtlanApi, se coloco en soluciones separadas debido a que .NET FRAMEWORK Windows Forms no es compatible en una
  misma solucion con el aplicativo AtlanApi .NET CORE 6, y se deben ejecutar en soluciones separadas (las disculpas del caso).


# Base de Datos
Importar base de datos como:

![image](https://github.com/melvinSosaMedrano/BancoAtlanRep/assets/115840261/0d4bded4-5dd3-4909-8ac7-696d581942cd)

Buscamos el archivo BDBACKUP.bacpac de la carpeta BASE DE DATOS en GITHUB

![image](https://github.com/melvinSosaMedrano/BancoAtlanRep/assets/115840261/004c737e-8495-40ab-b0fa-c4c836171ccb)

Luego Next, Next, y finish

La base de datos ya contiene poblado de datos.

(Se adjuntan como contingente dbscript.sql en caso de no poder restaurar la base de datos)


# Aplicación
Clonar este repositorio en tu máquina local.
Abre la solución con tu IDE preferido (recomendado: Visual Studio).
Restaura los paquetes NuGet.
configurar la cadena de conexión a la base de datos en el proyecto AtlanApi en el archivo AppSettings variable "BDconnection"
Configurar en el Proyecto VistaAlan  las variables: 

"RutaArchivo"  ruta donde se guardaran los archivos excel generados 

"NombreXLS" nombre con el que seran generados los archivos XLS (normalmente se mantiene la misma posiblemente no sea necesario configurar)

"ApiAtlan": Ruta web del aplicativo API cuando esta ejecutandose(normalmente se mantiene la misma posiblemente no sea necesario configurar)


Compila la solución para verificar que todo esté configurado correctamente.


# POSTMAN

Se Agrego documento de coleccion postman en la carpeta POSTMAN en repositorio GITHUB



  
