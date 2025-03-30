namespace APBD___Containers;

public class OverfillException : Exception
{
    public OverfillException() : base("Przepełniono kontener")
    {
        
    }
    
    public OverfillException(string message)
    {
        
    }
}