using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LightVCS
{
    /// <summary>
    /// Interaction logic for NewRepWindow.xaml
    /// </summary>
    public partial class NewRepWindow : Window
    {
        public NewRepWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            return;
            var pos = Mouse.GetPosition(this);
            if (pos.X > this.Left + this.Width)
                this.Close();
            if (pos.X < this.Left)
                this.Close();
            if (pos.Y > this.Top + this.Height)
                this.Close();
            if (pos.Y < this.Top)
                this.Close();
        }


        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
