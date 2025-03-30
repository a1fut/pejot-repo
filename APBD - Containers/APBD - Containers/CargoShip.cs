namespace APBD___Containers;

public class CargoShip
{
    private List<Container> containers = new List<Container>();
    private double maxSpeed { get; set; }
    private string name { get; set; }
    private int maxContainers { get; set; }
    private double maxWeightThatCanCarry { get; set; }

    public CargoShip(string name, double maxSpeed, int maxContainers, double maxWeightThatCanCarry)
    {
        this.maxSpeed = maxSpeed;
        this.name = name;
        this.maxContainers = maxContainers;
        this.maxWeightThatCanCarry = maxWeightThatCanCarry;
    }

    public void LoadContainer(Container container)
    {
        double currentTotalWeight = containers.Sum(c => c.totalWeight);
        if (containers.Count < maxContainers && currentTotalWeight + container.totalWeight <= maxWeightThatCanCarry)
        {
            containers.Add(container);
        }
        else
        {
            Console.WriteLine("Cannot load container: Maximum weight or container count exceeded");
        }
    }

    public void LoadContainers(List<Container> containerList)
    {
        foreach (var container in containerList)
        {
            LoadContainer(container);
        }
    }

    public void RemoveContainer(Container container)
    {
        containers.Remove(container);
    }

    public void ReplaceContainer(int containerNumber, Container newContainer)
    {
        if (containerNumber >= 0 && containerNumber < containers.Count)
        {
            containers[containerNumber] = newContainer;
        }
    }

    public void TransferContainerToAnotherShip(Container container, CargoShip otherShip)
    {
        if (containers.Contains(container))
        {
            otherShip.LoadContainer(container);
            RemoveContainer(container);
        }
    }

    public void UnloadContainer(Container container)
    {
        container.unloadContainer();
    }

    public void PrintContainerInfo(Container container)
    {
        Console.WriteLine(container.ToString());
        Console.WriteLine("------------------------");
    }

    public void PrintShipInfo()
    {
        Console.WriteLine($"Nazwa statku: {name}\nMaksymalna prędkość: {maxSpeed} węzłów\nMaksymalna liczba kontenerów: {maxContainers}\nMaksymalna waga kontenerów: {maxWeightThatCanCarry} kg");
        Console.WriteLine("Containers onboard:");
        foreach (var container in containers)
        {
            Console.WriteLine(container.ToString());
            Console.WriteLine("------------------------");
        }
    }
}
