using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_EventMulticast
{
    public delegate void EnemyAttackDelegate();
    public class App
    {
        public event EnemyAttackDelegate OnEnemyAttack;
        public void Run()
        {
            //event multicast
            IEnemy enemyGround = new EnemyGround("EnemyGround");
            IEnemy enemyFly = new EnemyFly("EnemyFly");

            OnEnemyAttack += enemyGround.Attack;
            OnEnemyAttack += enemyFly.Attack;

            OnEnemyAttack -= enemyGround.Attack;

            if (OnEnemyAttack != null)
                OnEnemyAttack();
        }
    }
}
