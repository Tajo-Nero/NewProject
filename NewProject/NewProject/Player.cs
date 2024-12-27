using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Player
    {
        Bullet _bullet;
       static int x = Map._x;
       static int y = Map._y;
        bool _active = false;

        // {   Map._y 세로 행 ,  Map._x 가로 열 } 제발 외워 
        // {   Map._y 세로 행  [0] ,  Map._x 가로 열 [1] } 로 써 제발좀 0,1 로 쓰기 제발
        // {   Map y  =[29]       ,      x =[42]        }
        public int[] PlayerCore = { y-1, x /2-2 };  
        public int[] PlayerLeft = { y-1, x /2-3};
        public int[] PlayerRight = { y-1, x /2-1};
        public int[] PlayerHead = { y-2, x /2-2};

        //이것때매 꼬였엇음
        //public int[] PlayerCore = { x - 2, x / 2 - 2 };
        //public int[] PlayerLeft = { x - 2, x / 2 - 3 };
        //public int[] PlayerRight = { x - 2, x / 2 - 1 };
        //public int[] PlayerHead = { x - 3, x / 2 - 2 };


        char _playerCore = 'H';
        char _playerLeft = ')';
        char _playerRight = '(';
        char _playerHead = '^';
        public Player()
        {
            //PlayerCore[0] = Map._y-1; PlayerCore[1] = Map._x /2-2;
            //PlayerLeft[0] = Map._y - 1; PlayerLeft[1] = PlayerCore[1] - 1;
            //PlayerRight[0] = Map._y-1; PlayerRight[1] = PlayerCore[1] + 1;
            //PlayerHead[0] = Map._y - 2; PlayerHead[1] = Map._x / 2-2;
            for (int i = 0; i < Map._y; i++)
            {
                for (int j = 0; j < Map._x; j++)
                {
                    if (i == PlayerLeft[0] && j == PlayerLeft[1])
                    {
                        Map._map[i, j] = _playerLeft;
                    }
                    else if (i == PlayerCore[0] && j == PlayerCore[1])
                    {
                        Map._map[i, j] = _playerCore;
                    }
                    else if (i == PlayerRight[0] && j == PlayerRight[1])
                    {
                        Map._map[i, j] = _playerRight;
                    }
                    else if (i == PlayerHead[0] && j == PlayerHead[1])
                    {
                        Map._map[i, j] = _playerHead;
                    }
                }
            }
        }
        //Map y=29 x =42
        public void PlayerMove(int x)
        {            
            PlayerLeft[1] -= x;
            PlayerCore[1] -= x;
            PlayerRight[1] -= x;
            PlayerHead[1] -= x;
            //if (PlayerLeft[1] <= Map._x - Map._x)//왼벽에 플레이어 왼날개 닿으면
            //{
            //    PlayerLeft[1] = Map._x + 1;
            //    PlayerCore[1] = Map._x + (Map._x + 1);
            //    PlayerRight[1] = Map._x + (Map._x + 2);
            //    PlayerHead[0] = Map._x + (Map._x + 1);
            //}
            if (PlayerLeft[1] <=Map._x-Map._x)//왼벽에 플레이어 왼날개 닿으면
            {
                PlayerLeft[1] = Map._x-Map._x+1;
                PlayerCore[1] = Map._x - Map._x + 2;
                PlayerRight[1] = Map._x - Map._x + 3;
                PlayerHead[1] = Map._x - Map._x + 2;
            }
            else if(PlayerRight[1] >Map._x-1)
            {
                PlayerLeft[1] = Map._x -4;
                PlayerCore[1] = Map._x -3;
                PlayerRight[1] = Map._x-2;
                PlayerHead[1] = Map._x-3;

            }
        }
        public void PlayerPirnt()
        {
            Console.SetCursorPosition(PlayerLeft[1], PlayerLeft[0]);
            Console.Write(_playerLeft);
            Console.SetCursorPosition(PlayerCore[1], PlayerCore[0]);
            Console.Write(_playerCore);
            Console.SetCursorPosition(PlayerRight[1], PlayerRight[0]);
            Console.Write(_playerRight);
            Console.SetCursorPosition(PlayerHead[1], PlayerHead[0]);
            Console.Write(_playerHead);
            
        }

        // {   Map._y 세로 행 ,  Map._x 가로 열 } 제발 외워 
        // {   Map._y 세로 행  [0] ,  Map._x 가로 열 [1] } 로 써 제발좀 0,1 로 쓰기 제발
        // {   Map y  =[29]       ,      x =[42]        }
        public void PlayerShot()
        {            
            _bullet = new Bullet();
            _bullet.playerBullet[0] = PlayerCore[0];//총알처음위치 플레이어 코어
            _bullet.playerBullet[1] = PlayerCore[1];
            //Console.SetCursorPosition(_bullet.playerBullet[1], _bullet.playerBullet[0]-=1);
            //Console.Write(_bullet._playerBullet);
            
        }
        public void playerUpdet()
        {
            _bullet = new Bullet();
            _bullet.playerBullet[0] = PlayerCore[0];
            _bullet.playerBullet[1] = PlayerCore[1];
            
            for (int i = 0; i < Map._y; i++)//맵 세로 입력값 까지 반복
            {                
                    if (_bullet.playerBullet[0] >= 1)//일단 위에 닿으면 안터지게함
                    {
                        Console.SetCursorPosition(_bullet.playerBullet[1], _bullet.playerBullet[0] -= 1);
                        Console.Write(_bullet._playerBullet);
                    }
                
            }

        }
    }
}
