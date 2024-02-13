# Moment_03

applikationen använder SQLite.

Skapades som ett DOTNET MVC projekt. Den använder även entity framework.

Innehåller två modeller: Author och Book. 

Innehåller en kontextfil - Bookcontext - vilken ärver från DBcontext.

En koppling till denna kontext-fil finns i program.cs filen

databaskopplingen sparas i appsettings.json filen.

det finns två migrations filer skapade för detta projekt: Inital och second. Den senare är den som används för att inkludera bägge modellerna.

slutligen skapades controllers och användargränssnitt (views) genom scaffolding med dotnet aspnet-codegenerator. Dessa innehåller CRUD funktionalitet.

Presentationen av data har modifierats för att exkludera fält i bok-tabellen - man får initialt bara se bokes titel. för att få veta mer ska man klicka på details. 

Bok och författare har en relation till varandra där en författare kan väljas för varje bok. 

