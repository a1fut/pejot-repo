using System.Transactions;

namespace APBD___Containers;


interface IHazardNotifier
{
    public void notify();
}

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
                } 
            }
            else
            {
                if (cargoWeight >= 0.9 * maxCapacity)
                {
                    notify();
                    this.cargoWeight = cargoWeight;
                } 
            }
        }
    }
}