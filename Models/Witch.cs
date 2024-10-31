namespace InheritanceMages.Models;
using InheritanceMages.Enums;
using InheritanceMages.Constants;

public class Witch : Mage
{
    private readonly FamiliarSpecies _familiarSpecies;
    private readonly string _familiarName;
    
    public Witch(string name, FamiliarSpecies familiarSpecies, string familiarName)
        : base(name)
    {
        _familiarSpecies = familiarSpecies;
        _familiarName = familiarName;
    }
    public void PetFamiliar()
    {
        Console.WriteLine($"{_name} pets {_familiarName}.");
        if(_familiarSpecies == FamiliarSpecies.Cat)
        {
            Console.WriteLine($"{WitchFamilarConstant.CatPetResponse}");
        }
        else if(_familiarSpecies == FamiliarSpecies.Crow)
        {
            Console.WriteLine($"{WitchFamilarConstant.CrowPetResponse}");
        }
        else if(_familiarSpecies == FamiliarSpecies.Snake)
        {
            Console.WriteLine($"{WitchFamilarConstant.SnakePetResponse}");
        }
        Console.ReadKey();
        Console.WriteLine();
    }
    public void BrewPotion()
    {
        Console.WriteLine($"{_name} brews a potion!");
        Console.ReadKey();
        Console.WriteLine();

    }
    public override void ChooseAction()
    {
        bool exitCheck = true;
        while(exitCheck == true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Cast a spell");
            Console.WriteLine("2. Pet familiar");
            Console.WriteLine("3. Brew a potion");
            Console.WriteLine("e - Exit game");
            bool check = true;
            string option;
            while(check == true)
            {
                option = ReadNonNullStringOption();
                if (option == "1")
                {
                    check = false;
                    ChooseSpell();
                }
                else if(option == "2")
                {
                    check = false;
                    PetFamiliar();
                }
                else if(option == "3")
                {
                    check = false;
                    BrewPotion();
                }
                else if(option == "e")
                {
                    check = false;
                    exitCheck = false;
                }
                else
                {
                    Console.WriteLine("Wrong number.");
                }
            }
        }
    }
}
