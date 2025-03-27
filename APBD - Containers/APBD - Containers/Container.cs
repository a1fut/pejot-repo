namespace APBD___Containers;

public abstract class Container
{
    protected double cargoWeight { get; set; }
    protected double height { get; set; }
    protected double containerWeight {get; set;}
    protected double deepness { get; set; }
    protected string serial = "KON-";
    protected double maxCapacity { get; set; }

    public Container(double cargoWeight, double height, double containerWeight, double deepness)
    {
     this.cargoWeight = cargoWeight;
     this.height = height;
     this.containerWeight = containerWeight;
     this.deepness = deepness;
    }

    public void loadContainer(double cargoWeight)
    {
        this.cargoWeight = cargoWeight;
    }

    public void unloadContainer()
    {
        this.cargoWeight = 0;
    }

    public abstract void generateSerialNumber();

    protected int randomNumber()
    {
        Random random = new Random();
        return random.Next(0, 9999);
    }


}