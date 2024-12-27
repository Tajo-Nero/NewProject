using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Enemy
    {
        static int x=Map._x;
        static int y=Map._y;
        public int[] EnemyCore = { y, x };
        public int[] EnemyLeft = { y, x };
        public int[] EnemyRight = { y, x };

        public char _enemyCore = 'x';
        public char _enemyLeft = 'T';
        public char _enemyRight = 'T';
       
        public Enemy()
        {
            
        }



    }
}
