namespace InheritanceMages.Models;

using System.Data;
using InheritanceMages.Enums;
using InheritanceMages.Constants;

public class Oracle : Mage
{
    private readonly List<string> deck = [
    "LuckyStar",
    "Hurricane",
    "Rock",
    "Spark",
    "Seed",
    "Warrior",
    "Treasure",
    "Death",
    "Puppy"
    ];
    
    public Oracle(string name)
        : base(name)
    {
        
    }

    public override void ChooseAction()
    {
        bool exitCheck = true;
        while(exitCheck == true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Cast a spell");
            Console.WriteLine("2. Predict Fate");
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
                if (option == "2")
                {
                    check = false;
                    PredictFate();
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
    void PredictFate()
    {
        int length = deck.Count;
        Random random = new Random();
        int pastCardNumber = random.Next(0, length);
        string pastCard = deck[pastCardNumber];
        int presentCardNumber;
        do
        {
            presentCardNumber = random.Next(0, length);
        }
        while(presentCardNumber == pastCardNumber);
        string presentCard = deck[presentCardNumber];
        int futureCardNumber;
        do
        {
            futureCardNumber = random.Next(0, length);
        }
        while(futureCardNumber == pastCardNumber || futureCardNumber == presentCardNumber);
        string futureCard = deck[futureCardNumber];
        Console.WriteLine($"{_name} shuffles the deck and puts three cards on the table.");
        Console.WriteLine("The card of your past is...");
        Console.WriteLine(PresentCard(pastCard));
        Console.ReadKey();
        Console.WriteLine("The card of your present is...");
        Console.WriteLine(PresentCard(presentCard));
        Console.ReadKey();
        Console.WriteLine("The card of your future is...");
        Console.WriteLine(PresentCard(futureCard));
        Console.ReadKey();
    }
    string PresentCard(string card)
    {
        if (card == "LuckyStar")
        {
            card += OracleCardsConstant.LuckyStarDescription;
        }
        else if(card == "Hurricane")
        {
            card += OracleCardsConstant.HurricaneDescription;
        }
        else if(card == "Rock")
        {
            card += OracleCardsConstant.RockDescription;
        }
        else if(card == "Spark")
        {
            card += OracleCardsConstant.SparkDescription;
        }
        else if(card == "Seed")
        {
            card += OracleCardsConstant.SeedDescription;
        }
        else if(card == "Warrior")
        {
            card += OracleCardsConstant.WarriorDescription;
        }
        else if(card == "Treasure")
        {
            card += OracleCardsConstant.TreasureDescription;
        }
        else if(card == "Death")
        {
            card += OracleCardsConstant.DeathDescription;
        }
        else if(card == "Puppy")
        {
            card += OracleCardsConstant.PuppyDescription;
        }
        return card;
    }
}