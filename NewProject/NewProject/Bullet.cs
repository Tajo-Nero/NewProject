using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    
    class Bullet
    {
        static int x = Map._x;
        static int y = Map._y;
       
        // {   Map._y 세로 행 ,  Map._x 가로 열 } 제발 외워 
        // {   Map._y 세로 행  [0] ,  Map._x 가로 열 [1] } 로 써 제발좀 0,1 로 쓰기 제발
        // {   Map y  =[29]       ,      x =[42]        }
       
       public int[] playerBullet= { y, x};
       //왜 여기선 반대가 되는거지 ? 쨋든 시작점 플레이어 코어 위치 [0]이 가로고 [1]이 세로가 되버림
       //플레이어가 이상해서 그랬음 바꿧음
       public char _playerBullet = 'H';
        



    }
}
