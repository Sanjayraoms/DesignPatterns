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

        public string Value { get; set; }

        public static readonly object SingletonLock = new object();

        private Singleton()
        {

        }

        public static Singleton GetSingletonInstance(string val)
        {
            if (singletonInstance == null)
            {
                lock (SingletonLock)
                {
                    if (singletonInstance == null)
                    {
                        singletonInstance = new Singleton();
                        singletonInstance.Value = val;
                    }
                }
            }
            return singletonInstance;
        }
    }
}
