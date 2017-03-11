using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appveyor_demo {
    public class Factorial {
        public long compute(long n) {
            if (n < 1) {
                return 0;
            } else if (n == 1) {
                return 1;
            }

            return n * compute(n - 1);
        }

        static void Main(string[] args) {
        }
    }
}
