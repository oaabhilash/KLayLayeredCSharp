using KLay.Kiml.Enums;

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
    public class KShapeLayout 
    {
        //TODO :: move this to a config file

        float _xpos = 0.0f; //KLAY: XPOS_EDEFAULT
        float _ypos = 0.0f; //KLAY: YPOS_EDEFAULT
        float _width = 0.0f; //KLAY: WIDTH_EDEFAULT
        float _height = 0.0f; //KLAY: HEIGHT_EDEFAULT

        float _labelSpacingLowerBound = 0.0f;
        float _labelSpacingUpperBound = 3.0f;

        float _labelSpacing = 0.0f;

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

        /** The graph contains comment boxes. */
        //GraphProperties.COMMENTS
        public bool GraphHasComments { get; set; }
        /** The graph contains dummy nodes representing external ports. */
        //GraphProperties.EXTERNAL_PORTS
        public bool GraphHasExternal_Ports { get; set; }
        /** The graph contains hyperedges. */
        //GraphProperties.HYPEREDGES
        public bool GraphHasHyperEdges { get; set; }
        
        /** The graph contains ports that are not free for positioning. */
        //GraphProperties.NON_FREE_PORTS
        public bool GraphHasNonFreePorts { get; set; }

        //graph contains ports on North and south side
        //GraphProperties.NORTH_SOUTH_PORTS
        public bool GraphHasNorthSouthPorts { get; set; }
        //graph contain self loops
        //GraphProperties.SELF_LOOPS
        public bool GraphHasSelfLoops { get; set; }

        //graph contains node labels
        //GraphProperties.CENTER_LABELS
        public bool GraphHasCenterLabels { get; set; }

        //graph contains head or tail edge labels
        //GraphProperties.END_LABELS
        public bool GraphHasEndLables { get; set; }

        // Determines the amount of space to be left around labels.
        // LayoutOptions.LABEL_SPACING
        public float Label_Spacing { get { return _labelSpacing; }
            set
            {
                _labelSpacing = value;
                if(_labelSpacing < _labelSpacingLowerBound || _labelSpacing > _labelSpacingUpperBound)
                {
                    throw new ArgumentException("Invalid Label Spacing Provided. Please provide a value within bounds");
                }
            }
            }
    }
}
