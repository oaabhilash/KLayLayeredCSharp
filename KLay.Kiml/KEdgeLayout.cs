using KLay.Kiml.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Kiml
{
    public class KEdgeLayout 
    {
        List<KPoint> _bendPoints = new List<KPoint>();
        public List<KPoint> BendPoints { get { return _bendPoints; }  }

        public KPoint SourcePoint { get; set; }

        public KPoint TargetPoint { get; set; }

    }
}
