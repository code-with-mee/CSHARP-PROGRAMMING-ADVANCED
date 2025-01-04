using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_DelegateCallback
{
    public delegate void LoadingDelegate(int value);
    public class Progress
    {
        public void Loading(LoadingDelegate loadingDel)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(loadingDel != null)
                {
                    loadingDel(i);
                    Thread.Sleep(100);
                }
            }
        }
    }
}
