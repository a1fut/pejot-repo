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
}