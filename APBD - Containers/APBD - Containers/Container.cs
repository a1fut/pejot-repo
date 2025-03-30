namespace APBD___Containers;
interface IHazardNotifier
{
    public void notify();
}
public enum ContainerType
{
    Liquid, Gas, Cool
}

public abstract class Container : OverfillException, IHazardNotifier
{
    protected ContainerType containerType { get; set; }
    protected double cargoWeight { get; set; }
    protected double height { get; set; }
    protected double containerWeight {get; set;}
    protected double deepness { get; set; }
    internal string serial {get; set;}
    protected double maxCapacity { get; set; }
    protected static int serialNumber = 0;
    internal double totalWeight { get; set; }

    
    public Container( double height, double containerWeight, double deepness, double maxCapacity )
    {
     this.height = height;
     this.containerWeight = containerWeight;
     this.deepness = deepness;
     this.maxCapacity = maxCapacity;
     totalWeight = containerWeight;
     serialNumber++;
    }

    public virtual void loadContainer(double cargoWeight)
    {
        if (cargoWeight > this.maxCapacity)
        {
            throw new OverfillException();
        }
        else
        {
            this.cargoWeight = cargoWeight;
            totalWeight += cargoWeight;
        }
    }

    public virtual void unloadContainer()
    {
        this.cargoWeight = 0;
    }

    protected void generateSerialNumber()
    {
        switch (containerType)
        {
            case ContainerType.Liquid:
                this.serial += "KON-L-" + serialNumber;
                break;
            case ContainerType.Gas:
                this.serial += "KON-G-" + serialNumber;
                break;
            case ContainerType.Cool:
                this.serial += "KON-C-" + serialNumber;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public override string ToString()
    {
        return $@"Numer seryjny: {serial}";
    }


    public void notify()
    {
        Console.WriteLine($"{serial}: WARNING!");
    }
}