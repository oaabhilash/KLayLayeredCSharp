using KLay.Kiml.Enums;
using KLay.Kiml.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  de.cau.cs.kieler.kiml.klayoutdata.impl.KShapeLayoutImpl
/// 
/// </summary>
namespace KLay.Kiml
{
    public class KShapeLayout : IKShapeLayout
    {
        float _xpos = 0.0f; //KLAY: XPOS_EDEFAULT
        float _ypos = 0.0f; //KLAY: YPOS_EDEFAULT
        float _width = 0.0f; //KLAY: WIDTH_EDEFAULT
        float _height = 0.0f; //KLAY: HEIGHT_EDEFAULT

        

        bool _modified = false;

        public float XPos
        {
            get { return _xpos; }
            set
            {
                _modified = (_xpos != value);
                _xpos = value;
            }
        }

        public float YPos
        {
            get { return _ypos; }
            set
            {
                _modified = (_ypos != value);
                _ypos = value;
            }
        }

        public float Width
        {
            get { return _width; }
            set
            {
                _modified = (_width != value);
                _width = value;
            }
        }

        public float Height
        {
            get { return _height; }
            set
            {
                _modified = (_height != value);
                _height = value;
            }
        }

        public KInsets Insets
        {
            get; set;
        }

        public bool IsModified()
        {
            return _modified;
        }

        public void ResetModificationFlag()
        {
            _modified = false;
        }

        public LayoutDirectionEnum LayoutDirection { get; set; }

        public PortConstraintsEnum PortConstraint { get; set; } 

        public PortSideEnum PortSide { get; set; }
    }
}
