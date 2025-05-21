Tekstowe RPG w C#

Projekt `Gierka` to prosta, tekstowa gra RPG napisana w języku C#. Gracz porusza się między lokacjami, wchodzi w interakcje z NPC, handluje w sklepie i podejmuje decyzje wpływające na przebieg rozgrywki.
Całość stworzona w celu nieszablonowego wykorzystania konsoli i nostalgii.

Funkcje gry

-  System dialogów z NPC
-  Sklep z kupowaniem i sprzedawaniem przedmiotów
-  Rozbudowa wioski
-  Walki z prostym interfacem



Struktura katalogów
RPGchyba/
├── Dashboards/ | Zarządzanie grą i graczem
│ └── Player.cs
├── Places/ | Lokacje w grze (np. Shop, Forest)
│ └── Shop.cs
├── Tools/  | Narzędzia pomocnicze (dialogi, losowe spotkania)
│ ├── Dialogue.cs
│ └── Encounters.cs
└── Program.cs  | Główna logika gry



Jak uruchomić?
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (np. .NET 6 lub 7)

1. Sklonuj repozytorium
2. Uruchom projekt za pomocą "dotnet run" w terminalu
   
  | 1) cd /gierka     2) dotnet run |
