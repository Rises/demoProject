using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoProject.Add
{
    public class AddIntegers
    {
        int a;
        int b;

        public AddIntegers()
        {
            this.a = 0;
            this.b = 0;
        }
        public AddIntegers(int a, int b) {
            this.a = a;
            this.b = b;
        }

        public int AddNumbers(int a, int b) {
            return a + b;
        }
    }
}
