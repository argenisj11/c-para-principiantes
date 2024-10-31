
using quiz_game;

Console.WriteLine("Quiz Game!");


var questions = new List<Question>();
var answers = new List<answer>();
var scores= new Dictionary<string, int>();
seedQuestionsandOptions();
startgame();

void AddAnswersToList(string answer, Question question)
{
    answers.Add(new answer
    {
        Questionid = question.id,
        selectedOption = GetSelectedOption(answer,question)

    });
}

option GetSelectedOption(string answer,Question question)
{

    
    var selectedoption = new option();
    foreach (var item in question.options)
    {
        if (item.id== int.Parse(answer))
        {
            selectedoption = item;
        }
    }


    return selectedoption;
}
void seedQuestionsandOptions()
{
    questions.Add(new Question
    {
        id = 1,
        QuestionText = "What if de bigger Country",
        options = new List<option>()
        {
            new option
            {
                id=1,
                optiontext="Rusia" , isvalid =true
            },
             new option
            {
                id=2,
                optiontext="australia"
            },
              new option
            {
                id=3,
                optiontext="brazil"
            },
               new option
            {
                id=4,
                optiontext="canada"
            }
        }
    });
    questions.Add(new Question
    {
        id = 2,
        QuestionText = "What it the Country with the greatest population",
        options = new List<option>()
        {
            new option
            {
                id=1,
                optiontext="Rusia"
            },
             new option
            {
                id=2,
                optiontext="china" , isvalid =true
            },
              new option
            {
                id=3,
                optiontext="brazil"
            },
               new option
            {
                id=4,
                optiontext="canada"
            }
        }
    });
    questions.Add(new Question
    {
        id = 3,
        QuestionText = "what color is the sky",
        options = new List<option>()
        {
            new option
            {
                id=1,
                optiontext="red"
            },
             new option
            {
                id=2,
                optiontext="blue" , isvalid =true
            },
              new option
            {
                id=3,
                optiontext="purple"
            },
               new option
            {
                id=4,
                optiontext="dark"
            }
        }
    });
    questions.Add(new Question
    {
        id = 4,
        QuestionText = "What it the valor of pi",
        options = new List<option>()
        {
            new option
            {
                id=1,
                optiontext="3,141516" , isvalid =true
            },
             new option
            {
                id=2,
                optiontext="2,4589" 
            },
              new option
            {
                id=3,
                optiontext="1,5654"
            },
               new option
            {
                id=4,
                optiontext="4,3354"
            }
        }
    });

}

void startgame()
{
    Console.WriteLine("Are you read......");
    Console.WriteLine("Whats is your name?: ");

    var player = Console.ReadLine();
    Console.WriteLine($"Hi!{player} let do this!!!");
    foreach (var item in questions)
    {
        Console.WriteLine(item.QuestionText);
        Console.WriteLine("Please, enter 1, 2, 3 or 4");
        foreach (var item1 in item.options)
        {
            Console.WriteLine($"{item1.id}. {item1.optiontext}");

        }
        var answer = GetSelectedAnswer();
        AddAnswersToList(answer, item);
        
        
    

    }

    int score = GetScore();
    Console.WriteLine($"Nice Try {player}!  You answered well {score} questions....");

    updatescore(player, score);
    showscore();
    answers = new List<answer>();
    Console.WriteLine("Do you Wanna play again??");
    Console.WriteLine("Enter yes to play again or any other key to stop....");
    var playagain = Console.ReadLine();
    if (playagain.ToLower().Trim() == "yes")
        startgame();
}

string GetSelectedAnswer()
{
    var answare = Console.ReadLine();
    if (answare != null && (answare == "1")|| (answare == "2") || (answare == "3") || (answare == "4") )
    {
        return answare;
    }
    else { 
    Console.WriteLine("that option not valid please try again");
    answare = GetSelectedAnswer();
    }
    return answare;
}

int GetScore()
{
    int score = 0;
    foreach (var item in answers)
    {
        if (item.selectedOption.isvalid)
        {
            score++;
        }
    }
    return score;
}
void updatescore(string player,int score)
{
    bool update = false;

    foreach (var item in scores)
    {
        if (item.Key == player)
        {
            scores[item.Key]= score;
            update=true;
        }
       
    }
    if (!update)
    {
        scores.Add(player, score);
    }
}

void showscore()
{
    Console.WriteLine("Scores: ");
    foreach (var item in scores)
    {
        Console.WriteLine($"{item.Key}.{item.Value}");
    }
}