using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{

    public class StackItem
    {
        string _num;
        StackItem _prev;

        public string GetNum()
        {
            return _num;
        }
        public void SetNum(string N)
        {
            _num = N;
        }
        public StackItem GetPrev()
        {
            return _prev;
        }
        public void SetPrev(StackItem pr)
        {
            _prev = pr;
        }
    }
    
}
