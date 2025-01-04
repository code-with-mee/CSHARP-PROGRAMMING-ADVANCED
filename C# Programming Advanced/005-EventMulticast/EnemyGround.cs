using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_EventMulticast
{
    public class EnemyGround : IEnemy
    {
        public string Name { get; }

        public EnemyGround(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            Console.WriteLine("{0} is attacking", Name);
        }
    }
}
