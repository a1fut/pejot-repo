namespace APBD___Containers
{
    public class CoolContainer : Container
    {
        string productType {get; set;}
        double containerTemperature {get; set;}

        private static readonly Dictionary<string, double> productAndItsTemperature = new()
        {
            {"Bananas", 13.3},
            {"Chocolate", 18},
            {"Fish", 2},
            {"Meat", -15},
            {"Ice cream", -18},
            {"Frozen pizza", -30},
            {"Cheese", 7.2},
            {"Sausages", 5},
            {"Butter", 20.5},
            {"Eggs", 19}
        };

        public CoolContainer(double height, double containerWeight, double deepness, double maxCapacity, string productType, double containerTemperature)
            : base(height, containerWeight, deepness, maxCapacity)
        {
            this.containerType = ContainerType.Cool;

            if (!productAndItsTemperature.ContainsKey(productType))
            {
                throw new ArgumentException("Invalid product type");
            }

            double requiredTemp = productAndItsTemperature[productType];
            
            if (containerTemperature < requiredTemp)
            {
                throw new ArgumentException($"{serial}: temperature is too low for '{productType}'");
            }

            this.productType = productType;
            this.containerTemperature = containerTemperature;
            generateSerialNumber();
        }
    }
}