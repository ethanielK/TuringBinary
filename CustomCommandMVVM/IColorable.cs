using System.Windows.Media;

namespace CustomCommandMVVM
{
    // 约束接口
    public interface IColorable
    {
        Color CurrentColor { get; set; }

        void FillColor(Color color);
        void ClearColor();
    }
}
