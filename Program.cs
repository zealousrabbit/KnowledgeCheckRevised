    Console.WriteLine("Please enter first number: ");
    int first = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter second number: ");
    int second = int.Parse(Console.ReadLine());

Console.WriteLine("State your operator: + - / * ");
string symboltype = Console.ReadLine();

switch (symboltype)
{

    case "+":
            
            Console.WriteLine($"The solution is: {first + second}");
        break;

    case "-":
         
            Console.WriteLine($"The solution is: {first - second}");
        break;

    case "*":
        
            Console.WriteLine($"The solution is: {first * second}");
        break;

    case "/":
     
            Console.WriteLine($"The solution is: {first / second}");
        break;

    default: 
      Console.WriteLine("I'm sorry, I don't know what you mean.");
      break;
    }
   