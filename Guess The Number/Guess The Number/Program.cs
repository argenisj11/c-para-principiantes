
using System.Numerics;
Random random = new Random();
int attempts = 0;

int higherAttemptsScore = 0;
string? player;
Console.WriteLine("Guess The Number");

GameStart();


void GameStart()

{

    Console.WriteLine("Hello! Welcome to the Game... ");
    Console.WriteLine("what is your name?: ");
    
    var ramdonNumber = random.Next(1, 10);
     player = Console.ReadLine();
    WantToPlay( ramdonNumber);




}
void WantToPlay(int ramdonNumber, bool playAgain = false)
{
    if(!playAgain)
    Console.WriteLine($"Hi! {player}, are you ready to play? (Enter Yes/No)");
    else
    Console.WriteLine("{player}, are you ready to play? (Enter Yes/No)");

    var wanttoplay = Console.ReadLine();

    switch (wanttoplay?.ToLower().Trim())
    {
        case "yes":
            play(ramdonNumber);
            break;
        case "no":
            DontPlay();
            break;
        default:
            Console.WriteLine("That not a valid option");
            WantToPlay(ramdonNumber);
            break;
    }

}

void play(int ramdonNumber)
{
    
    try
    {
        Console.WriteLine("Pick a number between 1 and 10");
        var picknumber = Console.ReadLine();
        if(picknumber is null)
        {
            throw new Exception("you need a pick a value");

        }
        if(int.Parse(picknumber)< 1|| int.Parse(picknumber) > 10)
        {
            throw new Exception(" pick a value between 1 and 10");
        }
        if(int.Parse(picknumber) == ramdonNumber)
        {
            YouGuessed();
        }
        else if (int.Parse(picknumber) < ramdonNumber)
        {
            Console.WriteLine("Try again! the number is higher...");
            attempts++;
            play(ramdonNumber);
        }
        else if (int.Parse(picknumber) > ramdonNumber)
        {
            Console.WriteLine("Try again! the number is lower...");
            attempts++;
            play(ramdonNumber);
        }
    }
    catch(Exception e)
    {
        Console.WriteLine($"There has been an error: {e.Message}");
        play(ramdonNumber);
    }
}
void DontPlay()
{
    Console.WriteLine("No worries! have a good day!");
}
void YouGuessed()
{
    Console.WriteLine("Congratulations you wins");
    attempts++;
    if(higherAttemptsScore == 0 || attempts< higherAttemptsScore )
        higherAttemptsScore= attempts;
    showscore();
    
    var ramdonNumber = random.Next(1, 10);
    Console.WriteLine($"it has taken you {attempts} attempts to guess de number");
    attempts = 0;
    WantToPlay(ramdonNumber);

}

void showscore()
{
    if (higherAttemptsScore == 0)
        Console.WriteLine("there is currently no high score, it's your for the taking!  ");
    else
        Console.WriteLine($"the current high socre is {higherAttemptsScore} attempts");
}