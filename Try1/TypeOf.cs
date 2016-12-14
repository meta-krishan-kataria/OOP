using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try1
{
    class TypeOf
    {
        /*static void Main()
        {
            Console.WriteLine(typeof(int).FullName);
            Console.WriteLine(typeof(string).Name);
            Console.WriteLine(typeof(Console) );
            int i = 0;
            Console.WriteLine(i.GetType());
            //Console.WriteLine(typeof(i));

        }
         * */
    }

    public class ExampleClass
    {
        public int sampleMember;
        public void SampleMethod() { }

        static void Main3()
        {
            Type t = typeof(ExampleClass);
            // Alternatively, you could use
            // ExampleClass obj = new ExampleClass();
            // Type t = obj.GetType();

            Console.WriteLine("Methods:");
            System.Reflection.MethodInfo[] methodInfo = t.GetMethods();

            foreach (System.Reflection.MethodInfo mInfo in methodInfo)
                Console.WriteLine(mInfo.ToString());

            Console.WriteLine("Members:");
            System.Reflection.MemberInfo[] memberInfo = t.GetMembers();

            foreach (System.Reflection.MemberInfo mInfo in memberInfo)
                Console.WriteLine(mInfo.ToString());
        }
    }

}
