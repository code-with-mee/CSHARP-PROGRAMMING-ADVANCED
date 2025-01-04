using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _002_DelegateCallback
{
    public class App
    {
        public void Run()
        {
            //delegate callback
            LoadingDelegate loadingDelegate = DownloadProgress;

            Progress progress = new Progress();
            progress.Loading(loadingDelegate);
        }

        private void DownloadProgress(int progress)
        {
            Console.WriteLine("download {0}%",progress);
        }
    }
}
