# FrameWork Web DotNet

https://docs.google.com/document/d/1CWPOiOckPzJrlxfEcY6iY0PMPXyhArF6uB4tWUeivk0/edit

## BrainStorm des Class et Interface

### Interface | IDrivable

```
Int Direction
Int Speed

public void TurnLeft() {}
public void TurnRight() {}
public void Accelerate() {}
public void Decelerate() {}
```

### Interface | IFuelable

```
Int FuelCapacity
Int FuelLevel
Enum <FuelType>

public void FillUpFuel() {}
```

### Interface | IElectricable

```
Int BatteryCapacity
Int BatteryLevel

public void RechargeBattery() {}
```

### Interface | IVehicle : IDrivable

```
Int Identification
String Name
Int Direction
Int Speed

public void TurnLeft() {}
public void TurnRight() {}
public void Accelerate() {}
public void Decelerate() {}
```

### Interface | IPerson

```
String FirstName
String LastName
DateTime BirthDate

public int GetAge() {}
```

### Interface | IRace

```
Array[Pilot] Members
Int MaxMemberCapacity

public bool IsRaceFull() {}
```

### Class | Pilot : IPerson

```
String FirstName { get; set; }
String LastName { get; set; }
String Email { get; set; }s
DateTime BirthDate { get; set; }
Vehicle FavoriteVehicle? { get; set; }

public int GetAge() {
// Retourne la date actuelle - la date de naissance pour avoir l'âge
}

public void SetNewFavoriteVehicle() {
// Define a new FavoriteVehicle
}
```

## 🐳 Docker

Docker c'est quoi ?

Il permet d'empaqueter une application.

### Docker Hub

Site des listes des images officielles pour les stacks docker.

Accèder au container :

`docker exec -it app-db sh`

### ORM

Couche de communication entre système de stockage de donnée et un programme informatique

**+ Pros :**

- Productivité et experience
- Reduction du code à écrire
- Consistance du système : normaliser des interactions entre code et BDD
- Pas besoin de comprendre le SQL pour utiliser une BDD SQL

**- Cons :**

- Dépendance
- Performances
- L'effet "boite noire"

### Entity Framework

Config :

```
var connectionString = "server=localhost;user=db_user;password=example;database=app_db";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

builder.Services.AddDbContext<AppDbContext>(
  dbContextOptions => dbContextOptions
    .UseMySql(connectionString, serverVersion)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors()
);
```

## Persistance d'un volume avec Docker

```yml
volumes:
  - ./database:/var/lib/mysql
```

&

```yml
volumes:
  database:
```

Convention de mapping :

- Nom de la colonne = Nom de la propriété du modèle

## Repository Pattern

Créer une couche entre l'accès et la modification des données en base de donnée et le code.

Clean Archi : Tout dépend du métier et le métier dépend du moins de choses possible.

Architécture en couche :

DB < Repository < Services < Application (Controllers) < Middleware

C'est une Interface qui va créer un contrat pour assurer les bonnes gestions des données.

Il est mieux de faire plusieurs Interfaces pour ne pas se retrouver à devoir implémenter des méthodes inutiles dans le contexte à cause des promesses des Interfaces.
