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

namespace MultiKontrolki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LadowanieGrida();
            
        }

        public void LadowanieGrida()
        {
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition());

            MainGrid.RowDefinitions.Add(new RowDefinition());
            MainGrid.RowDefinitions.Add(new RowDefinition());
            MainGrid.RowDefinitions.Add(new RowDefinition());

            Button przycisk;
            int i = 0;

            for (int rzad = 0; rzad < MainGrid.RowDefinitions.Count; rzad++)
            {
                for (int kolumna = 0; kolumna < MainGrid.ColumnDefinitions.Count; kolumna++)
                {
                    i++;
                    przycisk = new Button();
                    przycisk.Content = i.ToString();
                    przycisk.Click += new RoutedEventHandler(przycisk_Click);

                    przycisk.SetValue(Grid.ColumnProperty, kolumna);
                    przycisk.SetValue(Grid.RowProperty, rzad);
                    MainGrid.Children.Add(przycisk);
                }
            }
            


        }

        public void przycisk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("Kliknąłeś guzik nr {0}", (sender as Button).Content));
        }
    }
}
