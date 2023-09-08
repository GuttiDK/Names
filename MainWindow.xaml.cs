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
using System.Xml.Linq;

namespace Names
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

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (lstNames.Items.Count >= 6)
                {
                    lstNames.Items.Clear();
                    txtName.Clear();
                }
                else
                {
                    lstNames.Items.Add(txtName.Text);
                    txtName.Clear();
                }
            }
            else
            {
                MessageBox.Show("There are no names to remove.", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        private void ButtonRemoveName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                lstNames.Items.Remove(txtName.Text);
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("There are no names to remove.", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        private void ButtonClearNames_Click(object sender, RoutedEventArgs e)
        {
            if (lstNames.Items.Count > 0)
            {
                lstNames.Items.Clear();
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("There are no names to remove.", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        private void ButtonAllName_Click(object sender, RoutedEventArgs e)
        {
            if (lstNames.Items.Count > 0 && lstNames.Items.Contains(txtName.Text))
            {
                foreach (var item in lstNames.Items)
                {
                    if (item.ToString() == txtName.Text)
                    {
                        lstNames.Items.Remove(item);
                        txtName.Clear();
                    }
                }

            }
            else
            {
                MessageBox.Show("There are no names to remove.", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }
    }
}
