int fly = 100;
string plane = @" _                         
| \                        
|  \       ______          
--- \_____/  |_|_\____  |  
  \_______ --------- __>-} 
        \_____|_____/   |  ";


Console.CursorVisible = false;

Console.WriteLine(plane);

for (int i = 0; i < fly; i++)
{
    Console.Clear();
    Console.SetCursorPosition(i, 0);
    Console.Write(plane);
    Thread.Sleep(100);
}