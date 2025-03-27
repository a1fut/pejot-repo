using System.Transactions;

namespace APBD___Containers;

interface IHazardNotifier
{
    public void notify();
}

public class LiquidContainer : Container, IHazardNotifier
{

    public LiquidContainer(double cargoWeight, double height, double containerWeight, double deepness) : base(
        cargoWeight, height, containerWeight, deepness)
    {
        generateSerialNumber();
    }

    public override void generateSerialNumber()
    {
        this.serial += "L" + randomNumber();
    }
    public void notify()
    {
        Console.WriteLine("${this.serialNumber}: ");
    }
}