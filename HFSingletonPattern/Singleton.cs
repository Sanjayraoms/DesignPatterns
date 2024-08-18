using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFSingletonPattern
{
    public class Singleton
    {
        private static Singleton uniqueSingleton;

        public static readonly object SingletonLock = new object();
        private Singleton()
        {
        }

        public static Singleton GetSingleton()
        {
            if (uniqueSingleton == null)
            {
                lock (SingletonLock)
                {
                    if (uniqueSingleton == null)
                        uniqueSingleton = new Singleton();
                }
            }

            return uniqueSingleton;
        }
    }
}
