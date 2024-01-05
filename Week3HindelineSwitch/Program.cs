Console.WriteLine("Mis hinde sa said?");

string userGrade = Console.ReadLine().ToUpper();

switch(userGrade) 

{
    case "A":

        Console.WriteLine("Suurepärane!");
        break;

    case "B":

        Console.WriteLine("Väga hea!");
        break;
    case "C":

        Console.WriteLine("Hea!");
        break;
    case "D":

        Console.WriteLine("Rahuldav!");
        break;
    case "E":

        Console.WriteLine("Kasin!");
        break;
    case "F":

        Console.WriteLine("Pudulik!");
        break;

    default:
        Console.WriteLine("Vale väärtus!");
        break;
    }