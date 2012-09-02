using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.NullObjectPattern
{
    public class StudentNOP
    {
        public virtual Boolean IsNull
        {
            get { return false; }
        }

        public virtual void Method()
        {
            Console.WriteLine("Hello everyone!");
        }
    }

    public class NullStudentNOP : StudentNOP
    {
        private NullStudentNOP() { }

        public static NullStudentNOP GetInstance()
        {
            return new NullStudentNOP();
        }

        public override bool IsNull
        {
            get
            {
                return true;
            }
        }

        public override void Method() { }
    }

    public class StudentManager
    {
        private StudentNOP student = new StudentNOP();

        public StudentNOP Student
        {
            set { student = value ?? NullStudentNOP.GetInstance(); }
            get { return student; }
        }
    }
}
