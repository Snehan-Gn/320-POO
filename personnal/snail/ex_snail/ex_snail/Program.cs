int life = 50;
Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.Green;

for (int i = 0; i < life; i++)
{
    Console.Clear();
    Console.SetCursorPosition(i, 10);
    Console.Write("_@_ö");
    Thread.Sleep(100);
}

Console.Clear();
Console.SetCursorPosition(life, 10);
Console.Write("____");
Console.ReadLine();
