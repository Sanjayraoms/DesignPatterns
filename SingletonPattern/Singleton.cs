using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton singletonInstance;

        public static readonly object SingletonLock = new object();

        private Singleton()
        {

        }

        public static Singleton GetSingletonInstance()
        {
            if (singletonInstance == null)
            {
                lock (SingletonLock)
                {
                    if (singletonInstance == null)
                    {
                        singletonInstance = new Singleton();
                    }
                }
            }
            return singletonInstance;
        }
    }
}
