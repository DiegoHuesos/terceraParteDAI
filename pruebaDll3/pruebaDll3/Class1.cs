using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDll3
{
    public class Class1
    {
        private int num1 = 5;
        private int num2 = 3;

        public void setNum1(int n)
        {
            this.num1 = n;
        }

        public void setNum2(int n)
        {
            this.num2 = n;
        }

        public int multiplica()
        {
            return num1 * num2;
        }
    }
}
