using coords;

Console.WriteLine("Hi user.");
// string input = "";
Point Prince = new Point();
Point Princes = new Point();
while(true){
    try{
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("pls enter Prince x coord: ");
        Prince.x = int.Parse(Console.ReadLine());
        Console.Write("pls enter Prince y coord: ");
        Prince.y = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("pls enter Princes x coord: ");
        Princes.x = int.Parse(Console.ReadLine());
        Console.Write("pls enter Princes y coord: ");
        Princes.y = int.Parse(Console.ReadLine());
        Console.ResetColor();
    }catch(FormatException){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        Console.ResetColor();
        continue;   
    }
    break;
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Prince x: " + Prince.x);
Console.WriteLine("Prince y: " + Prince.y);
Console.WriteLine("Princes x: " + Princes.x);
Console.WriteLine("Princes y: " + Princes.y);
Console.ResetColor();

LinkedList<Planet> points = new LinkedList<Planet>();
Planet tmp;
int i = 0;
Console.WriteLine("now we start set planets");
do{
    tmp = new Planet();
    try{
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("pls enter Planets x coord: ");
        tmp.x = int.Parse(Console.ReadLine());
        Console.Write("pls enter Planets y coord: ");
        tmp.y = int.Parse(Console.ReadLine());
        Console.Write("pls enter Planets readius: ");
        tmp.redius = int.Parse(Console.ReadLine());
        tmp.id = i++;
        Console.ResetColor();
        points.AddLast(tmp);
    }
    catch(FormatException){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        Console.ResetColor();
        continue;
    }
}while(Calculate.will_continue() == 0);
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Points in the linked list:");
foreach (Planet point in points)
{
    Console.WriteLine($"id: {point.id}, readius: {point.redius}, x: {point.x}, y: {point.y}");
}
Prince.in_radius = new List<int>();
Prince = Calculate.PlanetCounter( Prince ,points);
Princes.in_radius = new List<int>();
Princes = Calculate.PlanetCounter( Princes ,points);

Console.WriteLine(Calculate.check(Prince, Princes));
