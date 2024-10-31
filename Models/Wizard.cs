namespace InheritanceMages.Models;
using InheritanceMages.Enums;
using InheritanceMages.Constants;

public class Wizard : Mage
{
    private readonly WizardGrimoire _grimoire;
    private readonly List<string> _knownSpells = [_mageSpell1];
    
    public Wizard(string name, WizardGrimoire grimoire)
        : base(name)
    {
        _grimoire = grimoire;
        _knownSpells = AddGrimoireSpells(grimoire);
    }
    public override void ChooseAction()
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
                    Console.WriteLine("Wrong number.");
                }
            }
        }
    }

    public override void ChooseSpell()
    {
        Console.WriteLine($"Choose a spell from the list:");
        foreach (string spell in _knownSpells)
        {
            int number = _knownSpells.IndexOf(spell) + 1;
            Console.WriteLine($"{number}. {spell}");
        }

        bool check = true;
        string option;
        while(check == true)
        { 
            option = ReadNonNullStringOption();
            if (option == "1")
            {
                check = false;
                CastSpell(_knownSpells[0]);
            }
            else if (option == "2")
            {
                check = false;
                CastSpell(_knownSpells[1]);
            }
            else if (option == "3")
            {
                check = false;
                CastSpell(_knownSpells[2]);
            }
            else if (option == "4")
            {
                check = false;
                CastSpell(_knownSpells[3]);
            }
            else
            {
                Console.WriteLine("Wrong option.");
            }
        }
    }

    public List<string> AddGrimoireSpells(WizardGrimoire type)
    {
        if(type == WizardGrimoire.BookOfFire)
        {
            string spell1 = WizardGrimoireConstant.bookOfFireSpell1;
            string spell2 = WizardGrimoireConstant.bookOfFireSpell2;
            string spell3 = WizardGrimoireConstant.bookOfFireSpell3;
            List<string> spellList = [_mageSpell1, spell1, spell2, spell3];
            return spellList;
        }
        else if(type == WizardGrimoire.BookOfLife)
        {
            string spell1 = WizardGrimoireConstant.bookOfLifeSpell1;
            string spell2 = WizardGrimoireConstant.bookOfLifeSpell2;
            string spell3 = WizardGrimoireConstant.bookOfLifeSpell3;
            List<string> spellList = [_mageSpell1, spell1, spell2, spell3];
            return spellList;
        }
        else if(type == WizardGrimoire.BookOfTime)
        {
            string spell1 = WizardGrimoireConstant.bookOfTimeSpell1;
            string spell2 = WizardGrimoireConstant.bookOfTimeSpell2;
            string spell3 = WizardGrimoireConstant.bookOfTimeSpell3;
            List<string> spellList = [_mageSpell1, spell1, spell2, spell3];
            return spellList;
        }
        else
        {
            return new List<string>();
        }
    }

}
