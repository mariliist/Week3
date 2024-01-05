// enter a number

Console.WriteLine("Enter a number:");

int userNum = Convert.ToInt32(Console.ReadLine());

// kas kasutaja arv on paars v paaritu

int result = userNum % 2;

if(result != 0)
{
    Console.WriteLine("User number is odd");
}
else
{
    Console.WriteLine("User number is even");
}



