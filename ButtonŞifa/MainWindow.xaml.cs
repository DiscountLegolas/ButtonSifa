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

namespace ButtonŞifa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int CurrentRow=0;
        private int CurrentColumn = 0;
        public MainWindow()
        {
            InitializeComponent();
            ButtonGrid.ColumnDefinitions.Add(new ColumnDefinition());
            ButtonGrid.ColumnDefinitions.Add(new ColumnDefinition());
            ButtonGrid.ColumnDefinitions.Add(new ColumnDefinition());
            ButtonGrid.RowDefinitions.Add(new RowDefinition());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button MyControl1 = new Button();
            MyControl1.Content = ButtonText1.Text;
            MyControl1.Background = Brushes.LightGray;
            MyControl1.Name = "Button" + CurrentRow.ToString()+CurrentColumn.ToString();
            MyControl1.Click += Change;
            if (CurrentColumn==3)
            {
                ButtonGrid.RowDefinitions.Add(new RowDefinition());
                CurrentRow++;
                CurrentColumn = 0;
            }
            Grid.SetColumn(MyControl1, CurrentColumn);
            Grid.SetRow(MyControl1, CurrentRow);
            ButtonGrid.Children.Add(MyControl1);
            CurrentColumn++;
        }
        private void Change(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Background==Brushes.GreenYellow)
            {
                button.Background = Brushes.LightGray;
            }
            else
            {
                button.Background = Brushes.GreenYellow;
            }
        }
    }
}
