namespace InheritanceMages.Models;

public class OracleCard
{
    public string Name {get;}
    public string Description {get;}
    public OracleCard(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
