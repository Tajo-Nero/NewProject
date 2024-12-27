using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Map
    {
        //Map y=29 x =42
        //스태틱으로 모든값 공유 ?
        public static int _y;//세로길이 행
        public static int _x;//가로길이 열
        public static char[,] _map;
      

        public static char _wall = '|';
        public static char _space = ' ';
        public Map(int y, int x)
        {
            _y = y;
            _x = x;
            _map = new char[_y, _x];
            //맵출력
            for (int i = 0; i < _y; i++)
            {
                for (int j = 0; j < _x; j++)
                {
                    if (j == 0 || j == _x - 1)
                    { _map[i, j] = _wall; }
                    else
                    { _map[i, j] = _space; }
                }
            }
        }
       static public void DrawMap()
        {
            Console.Clear();
            //출력하는 반복문
            for (int i = 0; i < _y; i++)
            {
                for (int j = 0; j < _x; j++)
                {
                    Console.Write(_map[i, j]);
                    
                }
                Console.WriteLine();
            }
        }
    }
}
