using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(29,42);
            Player _player = new Player();
            Stopwatch _stopwatch = new Stopwatch();
            Bullet _bullet = new Bullet();
            bool _Short = false;
            _stopwatch.Start();
            ConsoleKeyInfo isKey;            
            Console.CursorVisible = false;

            //Map y=29 x =42

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    isKey = Console.ReadKey(true);
                    if (isKey.Key == ConsoleKey.Spacebar)
                    {
                        _player.PlayerShot();
                    }
                    else if (isKey.Key == ConsoleKey.A)
                    {
                      _player.PlayerMove(3);
                    }
                    else if (isKey.Key == ConsoleKey.D)
                    {
                        _player.PlayerMove(-3);
                    }

                }
                if (_stopwatch.ElapsedMilliseconds > 100)
                {
                    
                    Map.DrawMap();
                    _player.PlayerPirnt();
                    _player.playerUpdet();
                    _stopwatch.Restart();
                }
            }


        }
    }
}
