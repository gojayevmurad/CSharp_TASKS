using System;
using System.Text;

namespace DelegateTask
{
    public delegate void Func(string text);

    public class MyClass
    {
        public static void Space(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str);

            for (int i = 0; i < (2 * str.Length - 1); i++)
            {
                if(i %2 != 0)
                {
                    stringBuilder.Insert(i, '_');
                }
            }
            Console.WriteLine(stringBuilder);

        }
        public static void Reverse(string str)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(str[str.Length - i - 1]);
            }

            Console.WriteLine(sb);

        }
    }

    public class Run
    {
        public void runFunc(DelegateTask.Func funcDell, string str)
        {
            funcDell.Invoke(str);
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();

            DelegateTask.Func funcDell = new DelegateTask.Func(MyClass.Space);
            funcDell += MyClass.Reverse;

            Run run = new Run();

            run.runFunc(funcDell, str);

        }

    }
}