namespace APBD___Containers;

public class GasContainer : Container
{
    public GasContainer(double height, double containerWeight, double deepness, double maxCapacity) : base(height, containerWeight, deepness, maxCapacity)
    {
        this.containerType = ContainerType.Gas;
        generateSerialNumber();
    }

    public override void unloadContainer()
    {
        this.cargoWeight = this.cargoWeight * 0.05;
    }
    public override string ToString()
    {
        return $"Numer seryjny: {serial}\nWaga kontenera: {containerWeight}kg\n" +
               $"Wysokość kontenera: {height}\nGłębokość kontenera: {deepness}\nŁadowność: {maxCapacity}\nWaga ładunku: {cargoWeight}\nWaga całkowita: {totalWeight}";
    }
}