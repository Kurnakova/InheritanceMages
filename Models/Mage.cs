namespace InheritanceMages.Models;
using InheritanceMages.Enums;

public class Mage
{
    private protected readonly string _name;
    private protected static readonly string _mageSpell1 = "Moon Blast";

    public Mage(string name)
    {
        _name = name;
    }

    private protected void CastSpell(string spell)
    {
        Console.WriteLine($"{_name} casts: {spell}!");
        Console.ReadKey();
        Console.WriteLine();
    }
    public virtual void ChooseSpell()
    {
        Console.WriteLine($"Choose a spell from the list: \n1. {_mageSpell1}");
        bool check = true;
        string option;
        while(check == true)
        { 
            option = ReadNonNullStringOption();
            if (option == "1")
            {
                check = false;
                CastSpell(_mageSpell1);
            }
            else
            {
                Console.WriteLine("Wrong option.");
            }
        }
    }
    public virtual void ChooseAction()
    {
        bool exitCheck = true;
        while(exitCheck == true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Cast a spell");
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
                else if(option == "e")
                {
                    check = false;
                    exitCheck = false;
                }
                else
                {
                    Console.WriteLine("Wrong option.");
                }
            }
        }
    }
private protected string ReadNonNullStringOption()
    {
        string? name;
        while (true)
        {
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                break;
            }
        }
        return name;
    }    
}
