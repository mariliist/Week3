// Mis nädalapäev täna on?

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.Write("It's Sunday");
}
else if (weekDay == 1)
{
    Console.Write("It's Monday");
}
else if (weekDay == 2)
{
    Console.Write("It's Tuesday");
}
else if (weekDay == 3)
{
    Console.Write("It's Wednesday");
}
else if (weekDay == 4)
{
    Console.Write("It's Thursday");
}
else if (weekDay == 5)
{
    Console.Write("It's Friday");
}
else
{
    Console.Write("It's Saturday");
}

Console.Write(" Have a nice day!");


