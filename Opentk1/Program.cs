﻿using System;

namespace Opentk1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game juego = new Game(800, 600, "Casa");
            juego.Run(60);
        }
    }
}
