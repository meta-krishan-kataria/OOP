using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try1
{
    class Pentagon<T>
    {
        private T[] arr=new T[5];
       
        // Change 1

        // Change 2
        
        // Chnage 3

        //cgghh 4

        //defining indexer
        public T this[int i]
        {

            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }

        }

    }

    class IndexerDemo
    {
        static int Main4()
        {

            Pentagon<string> pentagon = new Pentagon<string>();
            pentagon[1] = "KK";
            Console.WriteLine(pentagon[2]+"JJ");
            Console.WriteLine(pentagon[1]);

            return 0;

        }
    }
}
