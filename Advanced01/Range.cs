using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced01
{
    internal class Range <T> where T : struct,IComparable 
    {
        public T Start { get; set; }
        public T End { get; set; }
        public Range(T start, T end)
        {
            Start = start;
            End = end;
        }
        public bool IsInRange(T value)
        {
           
            if ( value.CompareTo(End) == -1 && value.CompareTo(Start)==1)
            {
                return true;
            }
            
            return false;
        }
        private T subtract(T a , T b ) 
        {
            if ((a is not char && b is not char) || (a is bool && b is not bool) || (a is DateTime && b is DateTime))
            {
                dynamic x = a;
                dynamic y = b;
                return x - y;
            }
            return default ;
        }
        public T Length()
        {
            return subtract(End , Start);
        }
    }
}
