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

namespace WPFHomework3Teleqram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void changeColor(object sender, MouseEventArgs e)
        {
            stackpanel.Background = new SolidColorBrush() { Color = Colors.Blue };
            label1.Foreground = new SolidColorBrush() {  Color = Colors.White };
            label2.Foreground = new SolidColorBrush() {  Color = Colors.White };
            label3.Foreground = new SolidColorBrush() {  Color = Colors.White };
        }

        private void returnColor(object sender, MouseEventArgs e)
        {
            stackpanel.Background = new SolidColorBrush() { Color = Colors.White };
            label1.Foreground = new SolidColorBrush() { Color = Colors.Black };
            label2.Foreground = new SolidColorBrush() { Color = Colors.Gray };
            label3.Foreground = new SolidColorBrush() { Color = Colors.Gray };
        }

        private void changeColor2(object sender, MouseEventArgs e)
        {
            stackpanel2.Background = new SolidColorBrush() { Color = Colors.Blue };
            headerLabel2.Foreground = new SolidColorBrush() { Color = Colors.White };
            messageLabel2.Foreground = new SolidColorBrush() { Color = Colors.White };
            timeLabel2.Foreground = new SolidColorBrush() { Color = Colors.White };
        }

        private void returnColor2(object sender, MouseEventArgs e)
        {
            stackpanel2.Background = new SolidColorBrush() { Color = Colors.White };
            headerLabel2.Foreground = new SolidColorBrush() { Color = Colors.Black };
            timeLabel2.Foreground = new SolidColorBrush() { Color = Colors.Gray };
            messageLabel2.Foreground = new SolidColorBrush() { Color = Colors.Gray };
        }

        private void changeColor3(object sender, MouseEventArgs e)
        {
            stackpanel3.Background = new SolidColorBrush() { Color = Colors.Blue };
            headerLabel3.Foreground = new SolidColorBrush() { Color = Colors.White };
            messageLabel3.Foreground = new SolidColorBrush() { Color = Colors.White };
            timeLabel3.Foreground = new SolidColorBrush() { Color = Colors.White };
        }

        private void returnColor3(object sender, MouseEventArgs e)
        {
            stackpanel3.Background = new SolidColorBrush() { Color = Colors.White };
            headerLabel3.Foreground = new SolidColorBrush() { Color = Colors.Black };
            timeLabel3.Foreground = new SolidColorBrush() { Color = Colors.Gray };
            messageLabel3.Foreground = new SolidColorBrush() { Color = Colors.Blue };
        }

        private void changeColor4(object sender, MouseEventArgs e)
        {
            stackpanel4.Background = new SolidColorBrush() { Color = Colors.Blue };
            headerLabel4.Foreground = new SolidColorBrush() { Color = Colors.White };
            messageLabel4.Foreground = new SolidColorBrush() { Color = Colors.White };
            timeLabel4.Foreground = new SolidColorBrush() { Color = Colors.White };
        }

        private void returnColor4(object sender, MouseEventArgs e)
        {
            stackpanel4.Background = new SolidColorBrush() { Color = Colors.White };
            headerLabel4.Foreground = new SolidColorBrush() { Color = Colors.Black };
            timeLabel4.Foreground = new SolidColorBrush() { Color = Colors.Gray };
            messageLabel4.Foreground = new SolidColorBrush() { Color = Colors.Blue };
        }

        private void changeColor5(object sender, MouseEventArgs e)
        {
            stackpanel5.Background = new SolidColorBrush() { Color = Colors.Blue };
            headerLabel5.Foreground = new SolidColorBrush() { Color = Colors.White };
            messageLabel5.Foreground = new SolidColorBrush() { Color = Colors.White };
            message2Label5.Foreground = new SolidColorBrush() { Color = Colors.White };
            timeLabel5.Foreground = new SolidColorBrush() { Color = Colors.White };
        }

        private void returnColor5(object sender, MouseEventArgs e)
        {
            stackpanel5.Background = new SolidColorBrush() { Color = Colors.White };
            headerLabel5.Foreground = new SolidColorBrush() { Color = Colors.Black };
            timeLabel5.Foreground = new SolidColorBrush() { Color = Colors.Gray };
            messageLabel5.Foreground = new SolidColorBrush() { Color = Colors.Blue };
            message2Label5.Foreground = new SolidColorBrush() { Color = Colors.Gray };
        }

        private void changeColor6(object sender, MouseEventArgs e)
        {
            stackpanel6.Background = new SolidColorBrush() { Color = Colors.Blue };
            headerLabel6.Foreground = new SolidColorBrush() { Color = Colors.White };
            messageLabel6.Foreground = new SolidColorBrush() { Color = Colors.White };
            timeLabel6.Foreground = new SolidColorBrush() { Color = Colors.White };
        }

        private void returnColor6(object sender, MouseEventArgs e)
        {
            stackpanel6.Background = new SolidColorBrush() { Color = Colors.White };
            headerLabel6.Foreground = new SolidColorBrush() { Color = Colors.Black };
            timeLabel6.Foreground = new SolidColorBrush() { Color = Colors.Gray };
            messageLabel6.Foreground = new SolidColorBrush() { Color = Colors.Gray };
        }

        private void changeColor7(object sender, MouseEventArgs e)
        {
            stackpanel7.Background = new SolidColorBrush() { Color = Colors.Blue };
            headerLabel7.Foreground = new SolidColorBrush() { Color = Colors.White };
            messageLabel7.Foreground = new SolidColorBrush() { Color = Colors.White };
            timeLabel7.Foreground = new SolidColorBrush() { Color = Colors.White };
        }

        private void returnColor7(object sender, MouseEventArgs e)
        {
            stackpanel7.Background = new SolidColorBrush() { Color = Colors.White };
            headerLabel7.Foreground = new SolidColorBrush() { Color = Colors.Black };
            timeLabel7.Foreground = new SolidColorBrush() { Color = Colors.Gray };
            messageLabel7.Foreground = new SolidColorBrush() { Color = Colors.Gray };
        }

        private void changeColor8(object sender, MouseEventArgs e)
        {
            stackpanel8.Background = new SolidColorBrush() { Color = Colors.Blue };
            headerLabel8.Foreground = new SolidColorBrush() { Color = Colors.White };
            messageLabel8.Foreground = new SolidColorBrush() { Color = Colors.White };
            timeLabel8.Foreground = new SolidColorBrush() { Color = Colors.White };
        }

        private void returnColor8(object sender, MouseEventArgs e)
        {
            stackpanel8.Background = new SolidColorBrush() { Color = Colors.White };
            headerLabel8.Foreground = new SolidColorBrush() { Color = Colors.Black };
            timeLabel8.Foreground = new SolidColorBrush() { Color = Colors.Gray };
            messageLabel8.Foreground = new SolidColorBrush() { Color = Colors.Blue };
        }
    }
}
