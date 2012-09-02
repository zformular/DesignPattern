using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.SingletonPattern
{
    public class StudentSP
    {
        private StudentSP() { }

        private static StudentSP instance = null;
        public static StudentSP GetInstance()
        {
            if (instance == null)
                instance = new StudentSP();
            return instance;
        }
    }
}
