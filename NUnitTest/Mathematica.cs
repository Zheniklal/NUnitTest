using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestedApp
{
    class Mathematica
    {
        public static int Div(int a, int b)
        {
            if (b == 0)
            {
                LogToFile.WriteToFile(false, "Dividing by 0.");
                throw new ArithmeticException("Div by 0");
            }
            else
            {
                int result = a / b;
                LogToFile.WriteToFile(true,"Dividing is correct.");
                return result;
            }
        }

        public static bool isMoreThan(int a, int b)
        {
            if (a > b)
            {
                LogToFile.WriteToFile(true, a + " is more than " + b);
                return true;
            }
            else
            {
                LogToFile.WriteToFile(false, a + " is not more than " + b);
                return false;
            }
        }

    }
}
