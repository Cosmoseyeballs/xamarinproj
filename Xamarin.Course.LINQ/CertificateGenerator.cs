using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Course.LINQ
{
    class CertificateGenerator
    {
        private PrimeGenerator _PrimeGenerator = new PrimeGenerator();
        void GeneratorCertificate()
        {
            _PrimeGenerator.GetNextPrime();
        }
    }
}
