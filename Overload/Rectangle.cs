using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Rectangle
    {
        private int a;
        private int b;
        public int A
        {
            get { return a; }
            set { 
                if (value < 1)
                    value = 1;
                a = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value < 1)
                    value = 1;
                b = value;
            }
        }
        public Rectangle():this(1,2) { }

        public Rectangle(int a,int b)
        {
            A = a;
            B = b;
        }
        public override string ToString()
        {
            return $"A = {A}\nB = {B}";
        }

        public override bool Equals(object obj)
        {
            Rectangle rectangle = (Rectangle)obj;
            return A == rectangle?.A && B == rectangle?.B;
        }

        public override int GetHashCode()
        {
            int hashCode = 1487665074;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            hashCode = hashCode * -1521134295 + B.GetHashCode();
            return hashCode;
        }

        public static Rectangle operator ++(Rectangle r)
        {
            r.A++;
            r.B++;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            if (r.A - 1 < 1 || r.B -1 <1)
                throw new Exception("Unable to perform operation.");
            r.A--;
            r.B--;
            return r;
        }
        public static Rectangle operator +(Rectangle r, int num)
        {
            if (r.A + num < 1 || r.B+num<1)
                throw new Exception("Unable to perform operation.");
            Rectangle res = new Rectangle(r.A + num, r.B+num);
            return res;
        }
        public static Rectangle operator -(Rectangle r, int num)
        {
            if (r.A - num < 1 || r.B - num < 1)
                throw new Exception("Unable to perform operation.");
            Rectangle res = new Rectangle(r.A - num, r.B - num);
            return res;
        }
        public static Rectangle operator *(Rectangle r, int num)
        {
            if (r.A * num < 1 || r.B * num < 1)
                throw new Exception("Unable to perform operation.");
            Rectangle res = new Rectangle(r.A * num, r.B* num);
            return res;
        }
        public static Rectangle operator /(Rectangle r, int num)
        {
            if (num == 0  || r.A / num < 1 || r.B / num < 1)
                throw new Exception("Unable to perform operation.");
            Rectangle res = new Rectangle(r.A / num, r.B / num);
            return res;
        }
        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }
        public static bool operator>(Rectangle r1,Rectangle r2)
        {
            return 2*(r1.A + r1.B) > 2*(r2.A + r2.B);
        }
        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return 2 * (r1.A + r1.B) < 2 * (r2.A + r2.B);
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return 2 * (r1.A + r1.B) >= 2 * (r2.A + r2.B);
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return 2 * (r1.A + r1.B) <= 2 * (r2.A + r2.B);
        }
        public static bool operator true(Rectangle r)
        {
            return r.A != 0 && r.B != 0;
        }
        public static bool operator false(Rectangle r)
        {
            return r.A == 0 || r.B == 0;
        }
        public static explicit operator int(Rectangle r)
        {
            return 2*(r.A + r.B);
        }
        public static explicit operator Square(Rectangle r)
        {
            return new Square(r.A > r.B ? r.A : r.B);
        }
    }
}
