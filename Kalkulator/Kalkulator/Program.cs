// See https://aka.ms/new-console-template for more information

while (true)
{
    int a, b;
    string[] input = Console.ReadLine().Split();
    if (input[0] == "kraj" || input[0] == "exit") break;
    if (input[0] == "new")
    {
        string temp = Console.ReadLine();
        Console.WriteLine(temp);
        continue;
    }
    if (input[0] == "yo")
    {
        Console.WriteLine("mama");
        continue;
    }
    if (input.Length != 3)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    a = int.Parse(input[0]);
    b = int.Parse(input[2]);
    switch (input[1])
    {
        case "+": Console.WriteLine(a + b); break;
        case "-": Console.WriteLine(a - b); break;
        case "*": Console.WriteLine(a * b); break;
        case "/": Console.WriteLine(a / b); break;
        case "^": Console.WriteLine("Ne znam kako radi pow u c#"); break;
    }
}
