
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
        public void Add(string num)
        {
            StackItem _currnew = new StackItem();
            _currnew.SetNum(num);
            _currnew.SetPrev(_curr);
            _curr = _currnew;
        }
        public string Remove()
        {
            string _num = _curr.GetNum();
            _curr = _curr.GetPrev();
            return _num.ToString();
        }
    }
}
