using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;
        Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
        Plane plane = new Plane();

        while (true)
        {
            plane.Update();
            Console.Clear();
            plane.Draw();
            Thread.Sleep(100);
        }
    }
}

static class Config
{
    public const int SCREEN_HEIGHT = 40;
    public const int SCREEN_WIDTH = 150;
}

class Plane
{
    private string[] view =
    {
        @" _                         ",
        @"| \                        ",
        @"|  \       ______          ",
        @"--- \_____/  |_|_\____  |  ",
        @"  \_______ --------- __>-} ",
        @"        \_____|_____/   |  "
    };

    private int _x;
    private int _timer;
    public List<Para> parachutists;

    public Plane()
    {
        _x = 0;
        _timer = 0;
        parachutists = new List<Para>();
    }

    public void Draw()
    {
        for (int i = 0; i < view.Length; i++)
        {
            if (_x < Config.SCREEN_WIDTH - view[i].Length)
            {
                Console.SetCursorPosition(_x, i);
                Console.Write(view[i]);
            }
        }

        foreach (var para in parachutists)
        {
            para.Draw();
        }
    }

    public void Update()
    {
        _timer++;
        _x = (_x + 1) % Config.SCREEN_WIDTH;

        if (_timer % 30 == 0)
        {
            parachutists.Add(new Para("P" + _timer, _x, view.Length));
        }

        foreach (var para in parachutists)
        {
            para.Update();
        }

        parachutists.RemoveAll(p => p.y > Config.SCREEN_HEIGHT - 6);
    }
}

class Para
{
    private string[] withoutParachute =
    {
        @"     ",
        @"     ",
        @"     ",
        @"  o  ",
        @" /░\ ",
        @" / \ ",
    };

    private string[] withParachute =
    {
        @" ___ ",
        @"/|||\",
        @"\   /",
        @" \o/ ",
        @"  ░  ",
        @" / \ ",
    };

    public string name;
    public int x;
    public int y;
    public bool parachuteState;

    public Para(string name, int startX, int startY)
    {
        this.name = name;
        this.x = startX;
        this.y = startY;
        this.parachuteState = false;
    }

    public void Update()
    {
        y++;
        if (y > 10)
        {
            parachuteState = true;
        }
    }

    public void Draw()
    {
        string[] art = parachuteState ? withParachute : withoutParachute;
        for (int i = 0; i < art.Length; i++)
        {
            int drawY = y + i;
            if (drawY < Config.SCREEN_HEIGHT)
            {
                Console.SetCursorPosition(x, drawY);
                Console.Write(art[i]);
            }
        }
    }
}
