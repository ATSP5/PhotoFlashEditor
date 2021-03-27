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

namespace PhotoEditor
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Layer> layers;
        public MainWindow()
        {
            InitializeComponent();
            layers = new List<Layer>();
            layers.Add(new Layer());
        }

       
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) //Wyłącz wszystkie włączone okna !!!
        {
           
        }

        private void LayerAdder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LayerDeleter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Menu_File_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Menu_File_Open_Click(object sender, RoutedEventArgs e)
        {
           MessageBox.Show( layers[0].AlocateLayer(20000, 20000).ToString());   //TO DO: Add index ofcreated layer!
        }

        private void Layer_Settings_AddLayer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
