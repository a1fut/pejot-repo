// See https://aka.ms/new-console-template for more information

using APBD___Containers;


// Tworzenie kontenerów różnych typów
LiquidContainer liquidContainer = new LiquidContainer(1000, 1500, 800, 3000, true);
CoolContainer coolContainer = new CoolContainer(1200, 1800, 900, 2500, "Bananas", 14);
GasContainer gasContainer = new GasContainer(1100, 1600, 850, 2000);

// Załadowanie ładunku do kontenerów
liquidContainer.loadContainer(1400);
coolContainer.loadContainer(2000);
gasContainer.loadContainer(1500);

// Tworzenie statków
CargoShip ship1 = new CargoShip("Jano", 40, 5, 10000);
CargoShip ship2 = new CargoShip("Norbert", 35, 3, 8000);

// Załadowanie kontenerów na statek
ship1.LoadContainer(liquidContainer);
ship1.LoadContainers(new List<Container> { coolContainer, gasContainer });

// Wypisanie informacji o statku
ship1.PrintShipInfo();

// Wypisanie informacji o konkretnym kontenerze
ship1.PrintContainerInfo(coolContainer);

// Zastąpienie kontenera na statku
CoolContainer newCoolContainer = new CoolContainer(1300, 1700, 950, 2600, "Chocolate", 18);
newCoolContainer.loadContainer(1500);
ship1.ReplaceContainer(1, newCoolContainer);

Console.WriteLine("Po zastąpieniu kontenera:");
ship1.PrintShipInfo();

// Przeniesienie kontenera między statkami
ship1.TransferContainerToAnotherShip(liquidContainer, ship2);

Console.WriteLine("Po przeniesieniu kontenera:");
ship1.PrintShipInfo();
ship2.PrintShipInfo();

// Usunięcie kontenera ze statku
ship1.RemoveContainer(gasContainer);

Console.WriteLine("Po usunięciu kontenera:");
ship1.PrintShipInfo();

// Rozładowanie kontenera
newCoolContainer.unloadContainer();
ship1.PrintContainerInfo(newCoolContainer);

// Przykłady notyfikacji
Console.WriteLine("\nPrzykłady notyfikacji:");
liquidContainer.notify();
coolContainer.notify();
gasContainer.notify();

// Przykład rzucania OverfillException tylko dla LiquidContainer
Console.WriteLine("\nPrzykład rzucania OverfillException:");

LiquidContainer overloadedLiquidContainer = new LiquidContainer(1000, 1500, 800, 1000, false);
overloadedLiquidContainer.loadContainer(1500);


