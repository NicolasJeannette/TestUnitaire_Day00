using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    internal class Tests
    {

        public static bool Should_return_first_duplicate_value()
        {
            List<int> inputs = new List<int>() { 1, 2, 3, 4, 5, 2 };
            int expectedOutput = 2;

            int result = Program.FirstDuplicateValue(inputs);

            return result == expectedOutput;      
        }
    }
}
