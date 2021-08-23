using CrochetDiagramMaker.Models.Stitches;
using CrochetDiagramMaker.Models.Stitches.Contracts;
using CrochetDiagramMaker.Renderers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CrochetDiagramMaker.Renderers
{
    public class WpfRenderer : IRenderer
    {
        private Canvas canvas;

        public WpfRenderer(Canvas canvas)
        {
            this.canvas = canvas;
        }
        public void Clear(IStitch stitch)
        {
            throw new NotImplementedException();
        }

        public void ClearAll(ICollection<IStitch> stitches)
        {
            throw new NotImplementedException();
        }

        public void Draw(IStitch stitch)
        {
            if (stitch.GetType().Name == nameof(RectangleStitch))
            {
                Rectangle rect = new Rectangle();
                rect.Width = 50;
                rect.Height = 100;
                rect.Stroke = Brushes.Black;
                rect.StrokeThickness = 2;
                rect.Fill = Brushes.Red;

                Canvas.SetTop(rect, stitch.Coordinates.Top);
                Canvas.SetLeft(rect, stitch.Coordinates.Left);
                canvas.Children.Add(rect);

            }
        }

        public void DrawAll(ICollection<IStitch> stitches)
        {
            throw new NotImplementedException();
        }
    }
}
