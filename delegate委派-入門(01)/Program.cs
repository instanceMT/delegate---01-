using System;

namespace delegate委派_入門_01_
{
    //在 namespace 定義委派
    public delegate void delegate1();
    internal class Program
    {
        //在類別定義委派
        public delegate int delegate2(int a);
        static void Main(string[] args)
        {
            var ex = new Ex();
            delegate1 d1 = ex.func1;
            delegate2 d2 = Ex.func2;
            //delegate1 d1 = new delegate1((new Ex()).func1);
            //delegate2 d2 = new delegate2(Ex.func2);

            #region delegate1
            d1();
            d1.Invoke();
            #endregion

            #region delegate2
            var s1 = d2.Invoke(2);
            var s2 = d2(3);
            Console.WriteLine($"s1={s1}");
            Console.WriteLine($"s2={s2}");
            #endregion

            Console.ReadKey();
        }
    }
   
    public class Ex
    {
        public void func1()
        {
            Console.WriteLine($"{nameof(func1)}被呼叫");
        }

        public static int func2(int a)
        {
            return a * a;
        }
    }
}