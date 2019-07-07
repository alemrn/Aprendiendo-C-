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

namespace SummonersAplication
{
    /// <summary>
    /// Lógica de interacción para GW.xaml
    /// </summary>
    public partial class GW : Page
    {
        public GW()
        {
            InitializeComponent();

            GridDeclaration(FireGrid, 0);
            GridDeclaration(WindGrid, 1);
            GridDeclaration(WaterGrid, 2);
            GridDeclaration(DarkGrid, 3);
            GridDeclaration(LightGrid, 4);

        }

        private void HomeClick(object sender, RoutedEventArgs e)
        {
            ExpenseItHome home = new ExpenseItHome();
            this.NavigationService.Navigate(home);
        }

        // type simboliza el tipo de elemento a incorporar en el grid
        // 0 -> Fuego
        // 1 -> viento
        // 2 -> Agua
        // 3 -> Dark
        // 4 -> Light
        private void GridDeclaration(Grid e, int type)
        {
            for (int i = 0; i < 7; i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                cd.Width = new GridLength(50);
                e.ColumnDefinitions.Add(cd);
                for (int j = 0; j < 8; j++)
                {
                    RowDefinition rd = new RowDefinition();
                    rd.Height = new GridLength(50);
                    e.RowDefinitions.Add(rd);
                    Image img = new Image();
                    switch (type)
                    {
                        case 0:
                            img.Source = new BitmapImage(new Uri("/Monsters/Fire/Zaiross_Icon.png", UriKind.Relative));
                            break;
                        case 1:
                            img.Source = new BitmapImage(new Uri("/Monsters/Wind/Jamire_Icon.png", UriKind.Relative));
                            break;
                        case 2:
                            img.Source = new BitmapImage(new Uri("/Monsters/Water/Verad_Icon.png", UriKind.Relative));
                            break;
                        case 3:
                            img.Source = new BitmapImage(new Uri("/Monsters/Dark/Grogen_Icon.png", UriKind.Relative));
                            break;
                        case 4:
                            img.Source = new BitmapImage(new Uri("/Monsters/Light/Zerath_Icon.png", UriKind.Relative));
                            break;
                    }

                    StackPanel stackPnl = new StackPanel();
                    stackPnl.Orientation = Orientation.Horizontal;
                    stackPnl.Margin = new Thickness(0);
                    stackPnl.Children.Add(img);
                    Button b = new Button();
                    b.Content = string.Format("Row: {0}, Column: {1}", j, i);
                    b.Content = stackPnl;
                    Grid.SetRow(b, j);
                    Grid.SetColumn(b, i);
                    e.Children.Add(b);
                }
            }
        }
    }
}
