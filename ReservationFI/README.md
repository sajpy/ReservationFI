# ReservationFI

ReservationFI is a WinForm application that serves as a showcase of what could a reservation system for rooms at FI look like.

## Installation

The database creation should be taken care of, however the ReservationDbContext contains a connectionString

```code
"Server=(LocalDB)\\MSSQLLocalDB;Database=ReservationFI;Trusted_Connection=True;"
```
which expects you are using SSMS and that this server is present. It might not be your case, your database might be called just (.),
but that depends on your setup. I believe you can connect to your database server.

One way to check your server's name and connect to it from Visual Studio is this: 

```code
View -> SQL Server Object Explorer -> Add SQL Server -> Browse -> Local
```
and choose the one that fits you. 
Upon clicking on the database server, you will see a Server Name, which in my case is 

```code
(localdb)\MSSQLLocalDB
```
Please edit the connectionString accordingly if needed.

Upon opening the Solution, you should be able to run the application with no issues, as I have created a class that takes care of seeding the data, called Seeder. The class creates some example Rooms and some Users, one of them is admin and the other is not.

Admin login data:
```code
Username: admin
Password: admin
```
and the other's data:

```code
Username: user
Password: user
```

If the application runs into any problem with database, consider following these next steps:

```code
Tools -> Nuget Package Manager -> Package Manager Console
```

and type these commands into the console:

```code
Add-Migration init
Update-Database
```

## Usage

Upon running the app you will be greeted by a login screen, which asks for your login data. I will leave the rest of exploring of the app to you, since I tried making it as easy as possible to navigate, and exploring is a part of the process.

## Contact

If you run into any problems with the application, please contact me at:

```code
514308@mail.muni.cz
or
pavol.cajkovsky@gmail.com
```
or at Discord:

```code
𝚜𝚊𝚓𝚙𝚢#6763
```
