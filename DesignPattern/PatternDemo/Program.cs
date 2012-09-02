using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternDemo.NullObjectPattern;
using PatternDemo.SingletonPattern;

namespace PatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Null Object Pattern

            StudentManager studentManager = new StudentManager();
            Console.WriteLine(studentManager.Student.IsNull);
            studentManager.Student.Method();

            studentManager.Student = null;
            Console.WriteLine(studentManager.Student.IsNull);
            studentManager.Student.Method();

            Console.WriteLine("Null Object Pattern");
            Console.WriteLine("-------------------------");
            #endregion

            #region Singleton Pattern

            StudentSP studentSP1 = StudentSP.GetInstance();
            StudentSP studentSP2 = StudentSP.GetInstance();
            Console.WriteLine(studentSP1.Equals(studentSP2));

            Console.WriteLine("Singleton Pattern");
            Console.WriteLine("------------------------");
            #endregion
        }
    }
}
