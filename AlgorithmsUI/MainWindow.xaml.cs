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
using CocktailSorting;

namespace AlgorithmsUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sorting<int> algorithm = new Sorting<int>();
        List<int> coll = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbAdd.Text, out int res))
            {
                coll.Add(res);
            }
            algorithm.Sort(coll);
        }
        Random rnd = new Random();
        private void btnRnd_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < rnd.Next(5, 15); i++)
            {
                coll.Add(rnd.Next(1,255));         
            }
            lbResultBefore.Content = "Коллекция до сортировки: ";
            foreach (var item in coll)
            {
                lbResultBefore.Content += " " + item;
            }
          
            //var a = algorithm.Sort(coll);
            algorithm.Sort(coll);
            //lbResultBefore.Content = $"Коллекция до сортировки: {algorithm.Sort(coll).TotalMilliseconds}";
            
            lbResultAfter.Content = "Коллекция после сортировки: ";
            foreach (var item in coll)
            {
                lbResultAfter.Content += " " + item;
            }
            //for (int i = 0; i < coll.Count; i++)
            //{
            //    tbResult.Text = coll[i].ToString() + " ";
            //}
            //foreach (var item in coll)
            //{
            //    tbResult.Text = item.ToString();
            //}
        }
    }
}
