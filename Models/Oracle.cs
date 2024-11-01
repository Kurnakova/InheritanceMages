namespace InheritanceMages.Models;

using System.Data;
using InheritanceMages.Enums;
using InheritanceMages.Constants;

public class Oracle : Mage
{
    private readonly List<OracleCard> deck = [
    new OracleCard(OracleCardsConstant.LuckyStarName, OracleCardsConstant.LuckyStarDescription),
    new OracleCard(OracleCardsConstant.HurricaneName, OracleCardsConstant.HurricaneDescription),
    new OracleCard(OracleCardsConstant.RockName, OracleCardsConstant.RockDescription),
    new OracleCard(OracleCardsConstant.SparkName, OracleCardsConstant.SparkDescription),
    new OracleCard(OracleCardsConstant.SeedName, OracleCardsConstant.SeedDescription),
    new OracleCard(OracleCardsConstant.WarriorName, OracleCardsConstant.WarriorDescription),
    new OracleCard(OracleCardsConstant.TreasureName, OracleCardsConstant.TreasureDescription),
    new OracleCard(OracleCardsConstant.DeathName, OracleCardsConstant.DeathDescription),
    new OracleCard(OracleCardsConstant.PuppyName, OracleCardsConstant.PuppyDescription),
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
        int presentCardNumber;
        do
        {
            presentCardNumber = random.Next(0, length);
        }
        while(presentCardNumber == pastCardNumber);
        int futureCardNumber;
        do
        {
            futureCardNumber = random.Next(0, length);
        }
        while(futureCardNumber == pastCardNumber || futureCardNumber == presentCardNumber);
        
        Console.WriteLine($"{_name} shuffles the deck and puts three cards on the table.");
        Console.WriteLine("The card of your past is...");
        Console.WriteLine($"{deck[pastCardNumber].Name}\n{deck[pastCardNumber].Description}");
        Console.ReadKey();
        Console.WriteLine("The card of your present is...");
        Console.WriteLine($"{deck[presentCardNumber].Name}\n{deck[presentCardNumber].Description}");
        Console.ReadKey();
        Console.WriteLine("The card of your future is...");
        Console.WriteLine($"{deck[futureCardNumber].Name}\n{deck[futureCardNumber].Description}");
        Console.ReadKey();
    }
}
