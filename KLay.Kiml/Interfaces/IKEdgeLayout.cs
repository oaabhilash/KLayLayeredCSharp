using System.Collections.Generic;
using KLay.Kiml.Entities;

namespace KLay.Kiml.Interfaces
{
    public interface IKEdgeLayout
    {
        List<KPoint> BendPoints { get; }
        KPoint SourcePoint { get; set; }
        KPoint TargetPoint { get; set; }
    }
}