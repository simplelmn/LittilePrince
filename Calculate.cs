using System.Xml.XPath;
using coords;

public class Calculate{
    public static int will_continue(){
        Console.WriteLine("do we have another Planet? (y / n)): ");
        if(Console.ReadLine() == "y"){
            return 0;
        }
        return 1;
    }

    static double CalculateDistance(Planet planet, Point human)
    {
        int deltaX = human.x - planet.x;
        int deltaY = human.y - planet.y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
    public static Point PlanetCounter(Point man, LinkedList<Planet> planets){
        // int result;
        foreach (Planet planet in planets){
            double distance = CalculateDistance(planet, man);
            if(distance <= planet.redius){
                man.in_radius.Add(planet.id);
            }
        }
        return man;
    }

    public static int check(Point Prince, Point Princes){
        int result = 0;
        int diff = 0;
        foreach(int numInP in Prince.in_radius){
            if(Princes.in_radius.Contains(numInP)){
                diff+=1;
            }
        }
        result += Prince.in_radius.Count;
        result += Princes.in_radius.Count;
        if(diff != 0){
            result -= (2 * diff);
        }
        return result;
    }
}

