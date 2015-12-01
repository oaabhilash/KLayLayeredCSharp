
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///KLAY:: de.cau.cs.kieler.kiml.klayoutdata.impl.KInsetsImpl 
/// 
/// Even though java code is implementing an interface, we are considering this as an entity
/// </summary>

namespace KLay.Kiml
{
    public class KInsets 
    {
        //KLAY:TOP_EDEFAULT
        float _top = 0.0f;

        //KLAY:BOTTOM_EDEFAULT
        float _bottom = 0.0f;

        //KLAY: LEFT_EDEFAULT
        float _left = 0.0f;

        //KLAY: RIGHT_EDEFAULT
        float _right = 0.0f;

        public float Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public float Bottom
        {
            get { return _bottom; }
            set { _bottom = value; }
        }

        public float Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public float Right
        {
            get { return _right; }
            set { _right = value; }
        }


        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(top: ");
            sb.Append(_top);
            sb.Append(", bottom: ");
            sb.Append(_bottom);
            sb.Append(", left: ");
            sb.Append(_left);
            sb.Append(", right: ");
            sb.Append(_right);
            sb.Append(")");
            return sb.ToString();
        }
    }
}
