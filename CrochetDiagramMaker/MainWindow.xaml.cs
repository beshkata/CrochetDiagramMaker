using CrochetDiagramMaker.Core;
using CrochetDiagramMaker.Models.Stitches;
using CrochetDiagramMaker.Renderers;
using CrochetDiagramMaker.Renderers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrochetDiagramMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Engine engine;
        IRenderer renderer;
        public MainWindow()
        {
            InitializeComponent();
            renderer = new WpfRenderer(MainCanvas);
            engine = new Engine(renderer);

        }

        private void MainCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point mousePosition = Mouse.GetPosition(MainCanvas);
            engine.CreateAndDrawNewStich(mousePosition.Y, mousePosition.X);
            //renderer.Draw(new RectangleStitch(mousePosition.X, mousePosition.Y));
        }
    }
}
