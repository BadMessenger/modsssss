using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTRKApp.AppData
{
    internal class Class1
    {
        public static PTRKBaseEntities1 c;
        public static PTRKBaseEntities1 context
        {
            get
            {
                if (c == null)
                    c = new PTRKBaseEntities1();
                return c;
            }
        }
    }
}
