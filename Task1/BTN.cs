using System.Collections.Generic;

namespace Task1
{
    public class BTN
    {
        public int Val { get; private set; }
        public BTN Left { get; private set; }
        public BTN Right { get; private set; }

        public BTN(int val, BTN left, BTN right)
        {
            Val = val;
            Left = left;
            Right = right;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is BTN))
            {
                return false;
            }

            var outher = (BTN)obj;

            if(Val != outher.Val)
            {
                return false;
            }

            if((Left != null && outher.Left == null) || (Left == null && outher.Left != null))
            {
                return false;
            }
            
            if ((Right != null && outher.Right == null) || (Right == null && outher.Right != null))
            {
                return false;
            }
            
            if (Left == null && outher.Left == null && Right == null && outher.Right == null)
            {
                return true;
            }

            if (!Left?.Equals(outher?.Left) ?? false)
            {
                return false;
            }

            if (!Right?.Equals(outher?.Right) ?? false)
            {
                return false;
            }

            return true;
        }

    }
}
