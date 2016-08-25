using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Course.LINQ
{
    class PrimeGenerator
    {
        private int _KnownPrimes;
        readonly List<int> KnownPrimes;

        public int GetNextPrime()
        {
            return 1;
        }
    }

    interface IPrimeGenerator
    {

    }
}
