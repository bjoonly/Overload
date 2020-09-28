using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Square
    {
        private int a;
        public int A
        {
            get
            { return a; }
            set
            {
                if (value < 1)
                    value =1;
                a = value;
            }
        }
        public Square(int a)
        {
            A = a;
        }
        public Square()
        {
            A = 1;
        }
        public override string ToString()
        {
            return $"A = {A}";
        }
        public static Square operator ++(Square s)
        {
            s.A++;
            return s;
        }
        public static Square operator --(Square s)
        {
            if(s.A-1<1)
                throw new Exception("Unable to perform operation.");
            s.A--;
            return s;
        }
        public static Square operator +(Square s,int num)
        {
            if (s.A + num < 1)
                throw new Exception("Unable to perform operation.");
            Square res = new Square(s.A + num);
            return res;    
        }
        public static Square operator-(Square s, int num)
        {
            if (s.A - num < 1)
                throw new Exception("Unable to perform operation.");
            Square res = new Square(s.A - num);
            return res;
        }
        public static Square operator *(Square s,int num)
        {
            if (s.A * num < 1)
                throw new Exception("Unable to perform operation.");
            Square res = new Square(s.A * num);
            return res;
        }
        public static Square operator /(Square s, int num)
        {
            if (num==0 || s.A / num < 1 )
                throw new Exception("Unable to perform operation.");
            Square res = new Square(s.A / num);
            return res;
        }
        
        public override bool Equals(object obj)
        {
            Square square = (Square)obj;
            return A == square?.A;
        }

        public override int GetHashCode()
        {
            int hashCode = 1531325144;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            return hashCode;
        }
        public static bool operator ==(Square s1, Square s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }
        public static bool operator >(Square s1,Square s2)
        {
            return s1.A > s2.A;
        }
        public static bool operator <(Square s1, Square s2)
        {
            return s1.A < s2.A;
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return s1.A >= s2.A;
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return s1.A <= s2.A;
        }
        public static bool operator true(Square s)
        {
            return s.A != 0;
        }
        public static bool operator false(Square s)
        {
            return s.A == 0;
        }
        public static implicit operator int(Square s)
        {
            return 4*s.A;
        }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A, s.A);
        }

    }
}
