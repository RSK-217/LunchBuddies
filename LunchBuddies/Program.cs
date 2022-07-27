using LunchBuddies;

List<LunchBuddy> companions = new List<LunchBuddy>()
{
    new LunchBuddy("Dorf", "Grumpton"),
    new LunchBuddy("Dorf", "Grumpton"),
    new LunchBuddy("Dorf", "Grumpton")
};

LunchBuddy firstBuddy = new LunchBuddy("Bill", "Bloppy");

firstBuddy.Eat();
firstBuddy.Eat("Pizza");
firstBuddy.Eat(companions);
firstBuddy.Eat("Pizza", companions);



Console.ReadLine();