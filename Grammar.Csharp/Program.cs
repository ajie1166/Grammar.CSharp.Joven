using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.String;//使用静态成员
namespace Grammar.Csharp
{
    class Program
    {
		
		
		
        string _name = string.Empty;
        public Program(string name) => _name = name;
        unsafe static void Main(string[] args)
        {
            #region 元组
            /*
              var tuple2 = new ValueTuple<int, string>(1, "lijie");
              // var d = tuple2.Item1;
              // var tuple = (one: 1, two: 2);
              var tuple21 = (one: 1, two: 2);

              var tuple = GetValueTuple(tuple21.one);//解构  解构元组就是将元组中的字段值赋值给声明的局部变量
              int sum = tuple.Item3;
              */
            #endregion

            //Dictionary<int, string> dic = new Dictionary<int, string>() { { 1, "lijie" }, { 2, "2" }, { 3, "4" } };
            //List<object> list = new List<object>() { "4", 2, 4, 6 };
            #region switch

            /* int sum = 0;
             int count = 0;
             foreach (var item in list)
             {
                 switch (item)
                 {
                     case String val when int.TryParse(val, out int v):
                         sum += v;
                         break;
                     case int val:
                         count += val;
                         break;
                     default:
                         break;

                 }

             }*/

            /* List<object> list = new List<object>
                {
                    "4",
                    2,
                    4,
                    6
                };
             int num = 0;
             int num2 = 0;

             foreach (object current in list)
             {
                 object obj = current;
                 object obj2 = obj;
                 object obj3 = obj2;

                 if (obj3 != null)
                 {

                     string text;
                     if ((text = (obj3 as string)) != null)//obj3 as string=>(string)obj3   as语法就是强类型转换,   as是一个永远不会报错的转换,转换成功就转换,转换不成功就为null
                     {
                         string s = text;
                         int num3;
                         if (int.TryParse(s, out num3))
                         {
                             num += num3;
                             continue;
                         }
                     }
                     int? num4 = obj3 as int?;
                     int valueOrDefault = num4.GetValueOrDefault();
                     if (num4.HasValue)
                     {
                         int num5 = valueOrDefault;
                         num2 += num5;
                     }
                 }
             }
             Console.WriteLine();
             Console.ReadKey();
             */

            /*object a = 4;
            int? text;
            text = a as int?;
            Console.Write(text);*/
            //unsafe
            //{
            /* int num = 2;
             int* p1 = &num;
             string str = "dad";
             GCHandle h = GCHandle.Alloc(num);
             IntPtr p = GCHandle.ToIntPtr(h);*/
            // }

            //int* p = (IntPtr)str;

            #endregion


            #region 局部函数

            #endregion

            #region 表达试体成员

            #endregion

            /* if (IsNullOrEmpty("222"))
             {
             }*/

            string nick = "lijie", address = "shanghai";
            string info = $"{nick}-{address}";//字符串插值  反编译string.format("{0}-{1}",nick,address);
            Console.WriteLine(info);
            Console.ReadKey();
        }

        private static ValueTuple<int, int, int> GetValueTuple(int seed)
        {
            int a = 1, b = 3, c = 6;
            a = seed - a;
            b = seed * b;
            c = seed + c;
            return (first: a, second: b, three: c);
        }
    }
}
