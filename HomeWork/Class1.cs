using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Class1
    {
        private static int count = 0;

        public Class1()
        {
            count++;
        }

        public static int Count()
        {
            return count;
        }
    }
}
