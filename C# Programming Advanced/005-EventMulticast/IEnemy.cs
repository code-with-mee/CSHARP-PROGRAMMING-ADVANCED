using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_EventMulticast
{
    public interface IEnemy
    {
        string Name { get; }
        void Attack();
    }
}
