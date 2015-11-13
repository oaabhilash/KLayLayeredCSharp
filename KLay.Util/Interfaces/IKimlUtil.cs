using KLay.Core.KGraph.Entities;
using KLay.Core.KGraph.Interfaces;

namespace KLay.Util.Interfaces
{
    public interface IKimlUtil
    {
        IKNode CreateInitializedKNode();
        KLabel CreateInitializedKLabel(IKNode parent);

        KPort CreateInitializedPort();

        KEdge CreateInitializedEdge();
    }
}