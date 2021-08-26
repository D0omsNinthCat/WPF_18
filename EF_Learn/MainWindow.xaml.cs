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

namespace EF_Learn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private nordwind2021Entities context;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            context = new nordwind2021Entities();

            List<String> liste = (from s in context.Personal
                                  select s.Ort).Distinct().ToList();

            CB_Stadt.ItemsSource = liste;
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            var query = (from d in context.Personal select d).OrderByDescending(q => q.Personal_Nr).FirstOrDefault();
            if (query != null)
            {
                context.Personal.Remove(query);
                context.SaveChanges();
            }
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            var tst = new Personal
            {
                Vorname = "AnyVorname",
                Nachname = "AnyNachname"

            };
            context.Personal.Add(tst);
            context.SaveChanges();
        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            var query3 = (from u in context.Personal
                          where (u.Nachname == LB_Personal.SelectedItem.ToString())
                          where (u.Ort == CB_Stadt.SelectedItem.ToString())
                          select u).FirstOrDefault();

            query3.Vorname = textBox_Name.Text;
            query3.Nachname = textBox_Other.Text;
            query3.Land = comboBox_ID.SelectedItem.ToString();
            context.SaveChanges();
        }

        private void CB_Stadt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LB_Personal.Items.Clear();
            string selectedItem = CB_Stadt.SelectedItem.ToString();

            var query1 = (from o in context.Personal
                         where (o.Ort == selectedItem)
                         select o).ToList();

            foreach (Personal per in query1)
            {
                LB_Personal.Items.Add(per.Nachname);
            }
            ItemCollection test = LB_Personal.Items;
        }

        private void LB_Personal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_ID.Items.Clear();
            string selectedItem = LB_Personal.SelectedItem.ToString();

            var query2 = (from u in context.Personal
                          where (u.Nachname == selectedItem)
                          where (u.Ort == CB_Stadt.SelectedItem.ToString())
                          select u).FirstOrDefault();

            textBox_Name.Text = query2.Vorname;
            textBox_Other.Text = query2.Nachname;

            var landListe = context.Personal
                                .Where(t => t.Land != null)
                                .Select(t => new { t.Land })
                                .Distinct().ToArray();
            foreach (var i in landListe)
            {
                comboBox_ID.Items.Add(i.Land);
            }

            int counter = 0;
            foreach(var Land in landListe)
            {
                if(Land.Land.ToString() == query2.Land.ToString())
                {
                    comboBox_ID.SelectedIndex = counter;
                }
                counter++;
            }
        }

        private void button_Overview_Click(object sender, RoutedEventArgs e)
        {
            popup_Overview.IsOpen = true;

        }
    }
}
