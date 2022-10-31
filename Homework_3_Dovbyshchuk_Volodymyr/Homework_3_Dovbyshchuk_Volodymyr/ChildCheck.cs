using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Dovbyshchuk_Volodymyr
{
    internal class ChildCheck : Check
    {
        public void OutPutStorage(Storage storage)
        {
            Console.WriteLine(storage.ToString());
        }
    }
}
