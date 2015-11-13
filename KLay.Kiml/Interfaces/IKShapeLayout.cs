using KLay.Kiml.Enums;

namespace KLay.Kiml.Interfaces
{
    public interface IKShapeLayout
    {
        float Height { get; set; }
        KInsets Insets { get; set; }
        float Width { get; set; }
        float XPos { get; set; }
        float YPos { get; set; }

        bool IsModified();
        void ResetModificationFlag();

        LayoutDirectionEnum LayoutDirection { get; set; }

        PortConstraintsEnum PortConstraint { get; set; }

        PortSideEnum PortSide { get; set; }
    }
}