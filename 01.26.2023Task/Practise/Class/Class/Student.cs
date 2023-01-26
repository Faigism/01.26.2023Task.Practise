using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Student
    {
        public string Fullname;
        public string GroupNo;
        public double Point;

        public bool IsGraduate()
        {
            if (this.Point >= 65)
                return true;
            else
                return false;
        }
        public string GetInfo()
        {
            return $"FullName: {Fullname} - GroupNo: {GroupNo} - Point: {Point} - Graduated: {IsGraduate()}";

        }
    }
}
