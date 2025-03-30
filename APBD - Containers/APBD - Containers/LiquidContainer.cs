using System.Transactions;

namespace APBD___Containers;




public class LiquidContainer : Container
{
    
    bool isHazardous;

    public LiquidContainer(double height, double containerWeight, double deepness, double maxCapacity, bool isHazardous) : base(height, containerWeight, deepness, maxCapacity)
    {
        this.isHazardous = isHazardous;
        this.containerType = ContainerType.Liquid;
        generateSerialNumber();
    }

    public override void loadContainer(double cargoWeight)
    {
        if (cargoWeight > maxCapacity) throw new OverflowException($"{serial}: cannot have more than {maxCapacity} capacity");
        else
        {
            if (isHazardous)
            {
                if (cargoWeight >= 0.5 * maxCapacity)
                {
                    notify();
                    this.cargoWeight = cargoWeight;
                    totalWeight += this.cargoWeight;
                } 
            }
            else
            {
                if (cargoWeight >= 0.9 * maxCapacity)
                {
                    notify();
                    this.cargoWeight = cargoWeight;
                    totalWeight += this.cargoWeight;
                } 
            }
        }
    }
    public override string ToString()
    {
        return $"Numer seryjny: {serial}\nWaga kontenera: {containerWeight}kg\nTyp ładunku: {(isHazardous ? "Niebezpieczny" : "Bezpieczny")}\n"+
               $"Wysokość kontenera: {height}\nGłębokość kontenera: {deepness}\nŁadowność: {maxCapacity}\nWaga ładunku: {cargoWeight}\nWaga całkowita: {totalWeight}";
    }
}