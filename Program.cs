using InheritanceMages.Models;
using InheritanceMages.Enums;
using InheritanceMages.Constants;

Mage character = ChooseClass();
character.ChooseAction();

Mage ChooseClass()
{
    Console.WriteLine("Choose class:\n1. Mage\n2. Witch\n3. Wizard\n4. Oracle");
    bool check = true;
    string option;
    while(check == true)
    { 
        option = ReadNonNullStringOption();
        if (option == "1")
        {
            check = false;
            return CreateMage();
        }
        else if (option == "2")
        {
            check = false;
            return CreateWitch();
        }
        else if (option == "3")
        {
            check = false;
            return CreateWizard();
        }
        else if (option == "4")
        {
            check = false;
            return CreateOracle();
        }
        else
        {
            Console.WriteLine("Wrong number.");
        }
    }
    return CreateMage();
}

Mage CreateMage()
{
    Console.WriteLine("Name your mage");
    string name = ReadNonNullStringOption();
    return new Mage(name);
}

Witch CreateWitch()
{
    Console.WriteLine("Name your witch");
    string name = ReadNonNullStringOption();
    Console.WriteLine("Choose familiar:\n1. Cat\n2. Crow\n3. Snake");
    FamiliarSpecies familiarSpecies = ChooseFamiliar();
    Console.WriteLine("Name familiar");
    string familiarName = ReadNonNullStringOption();
    return new Witch(name, familiarSpecies, familiarName);
}

Wizard CreateWizard()
{
    Console.WriteLine("Name your wizard");
    string name = ReadNonNullStringOption();
    Console.WriteLine("Choose your grimoire:\n1. Book of Fire\n2. Book of Life\n3. Book of Time");
    string option = ReadNonNullStringOption();
    WizardGrimoire grimoire = WizardGrimoire.BookOfFire;
    if (option == "1")
    {
        grimoire = WizardGrimoire.BookOfFire;
    }
    else if (option == "2")
    {
        grimoire = WizardGrimoire.BookOfLife;
    }
    else if (option == "3")
    {
        grimoire = WizardGrimoire.BookOfTime;
    }
    return new Wizard(name, grimoire);
}

Mage CreateOracle()
{
    Console.WriteLine("Name your oracle");
    string name = ReadNonNullStringOption();
    return new Oracle(name);
}

FamiliarSpecies ChooseFamiliar()
{
    string option;
    bool check = true;
    while(check == true)
    { 
        option = ReadNonNullStringOption();
        if (option == "1")
        {
            check = false;
            return FamiliarSpecies.Cat;
        }
        else if (option == "2")
        {
            check = false;
            return FamiliarSpecies.Crow;
        }
        else if (option == "3")
        {
            check = false;
            return FamiliarSpecies.Snake;
        }
        else
        {
            Console.WriteLine("Wrong number.");
        }
    }
    return FamiliarSpecies.Cat;
}

string ReadNonNullStringOption()
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
