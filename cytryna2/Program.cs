// // See https://aka.ms/new-console-template for more information

// Console.WriteLine("What's your \"name\"?");
// string name = Console.ReadLine()!;
// // Console.ReadLine();

// // Console.WriteLine("Hello, " + name "!");
// Console.WriteLine($"Hello, {name} !"); //wyswietla to samo co linika powyzej

// if (name == "Link")
//     Console.WriteLine("Like the legendary hero?");
// else
//     Console.WriteLine("Nice to meet you.");
    



    Console.WriteLine("Rock, paper, scissors!");

    Console.WriteLine("Player 1, provide sign (rock/paper/scissors)");
    string firstSign = Console.ReadLine()!;
    // czy podany znak NIE jest jednym z oczekiwanych?
// if (firstSign != "rock" && != "paper" && != "scissors")
    while (! (firstSign == "rock" || firstSign == "paper" || firstSign == "scissors"))
    //wyświetl że znak jest poprawny
    Console.WriteLine("Provide CORRECT sign!");
    //pozwól poprawić swoje zachowanie (podaj ponownie znak)
   firstSign = Console.ReadLine()!;
    
    Console.WriteLine("Player 2, provide sign (rock/paper/scissors)");
    string secondSign = Console.ReadLine()!;
    
    // if (firstSign == secondSign)

if (firstSign.Equals(secondSign, StringComparison.OrdinalIgnoreCase))
    {
    Console.WriteLine("Draw!");
    }
    else if ( (firstSign == "rock" && secondSign == "scissors")
           || (firstSign == "paper" && secondSign == "rock")
           || (firstSign == "scissors" && secondSign == "paper"))

{
     Console.WriteLine("Player 1 won!!");
}



//     else if (firstSign == "rock" && secondSign == "scissors")
// {
//     Console.WriteLine("Player 1 won!!");
// }
// else if (firstSign == "paper" && secondSign == "rock")
// {
//     Console.WriteLine("Player 1 won!!");
// }
// else if (firstSign == "scissors" && secondSign == "paper")
// {
//     Console.WriteLine("Player 1 won!!");
// }
// else
//change time baby!!!