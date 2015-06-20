
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class MyStack
    {
        StackItem _curr;
        public void Add(string str)
        {
            StackItem _currnew = new StackItem();
            _currnew._str = str;
            _currnew._prev = _curr;
            _curr = _currnew;
        }
        public string Remove()
        {
            string _num = _curr._str;
            _curr = _curr._prev;
            return _num.ToString();
        }
    }
}
