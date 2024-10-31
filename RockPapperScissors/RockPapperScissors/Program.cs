
Console.WriteLine("Piedra papel tijeraz");

while (true)
{
    Console.WriteLine("Comenzar");
    Console.WriteLine("Incio");
  
    var selectedChoice = SelectChoice();
    var yourchoice = char.Parse(selectedChoice.ToString());

    Console.WriteLine($"tu seleccion {yourchoice}");

    var OpponentChoice = getoppenentChoice();


    Console.WriteLine($"mi seleccion es {OpponentChoice}");

    Decidewinner(OpponentChoice, yourchoice);

    Console.WriteLine("Quieres jugar de nuevo?");
    Console.WriteLine("Escribe si si quieres jugar de nuevo o presiona cualquier otra tecla para dejar de jugar.......");
    var Playagain = Console.ReadLine();
    if (Playagain?.ToLower() == "si")
        continue;
    else
        break;

}
string SelectChoice()
{
    Console.WriteLine("elije R, P or S: R[Piedra] P[papel] S[Tiejeras] ");
    var SelectedChoice = Console.ReadLine() ;
    if (SelectedChoice?.ToLower() != "r" && SelectedChoice?.ToLower() != "p"&& SelectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("Porfavor Ingresa una letra valida");
        SelectedChoice = SelectChoice();

    }
    return SelectedChoice;

} 

char getoppenentChoice()
{
    char[] options = new char[] {'R','P','S'};
    Random random= new Random();
    int RandomIndex = random.Next(0, options.Length);

    return options[RandomIndex];

}


void Decidewinner(char OpponentChoice, char yourchoice)
{

    if (OpponentChoice == yourchoice)
    {
        Console.WriteLine("empate!");
        return;

    }

    switch(yourchoice)
    {
        case 'r':
            if (OpponentChoice == 'P')
                Console.WriteLine("yo gane papel gana piedra!");
            if (OpponentChoice == 'S')
                Console.WriteLine("Ganaste piedra gana tiejeras!");
            break;

        case 'R':
            if (OpponentChoice == 'P')
                Console.WriteLine("yo gane papel gana piedra!");
            if (OpponentChoice == 'S')
                Console.WriteLine("Ganaste piedra gana tiejeras!");
            break;
        case 's':
            if (OpponentChoice == 'P')
                Console.WriteLine("Ganaste tijeras gana papel!");
            if (OpponentChoice == 'R')
                Console.WriteLine("Perdiste piedra gana tiejeras!");
            break;
        case 'S':
            if (OpponentChoice == 'P')
                Console.WriteLine("Ganaste tijeras gana papel!");
            if (OpponentChoice == 'R')
                Console.WriteLine("Perdiste piedra gana tiejeras!");
            break;
        case 'p':
            if (OpponentChoice == 'R')
                Console.WriteLine("Ganaste papel gana piedra!");
            if (OpponentChoice == 'S')
                Console.WriteLine("Perdiste tiejeras gana papel!");
            break;
        case 'P':
        default:
            break;

    }
}
