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

namespace generic
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             Dictionary<string, string> dict = new Dictionary<string,string>();
            dict.Add("Name", txtname.Text);
            dict.Add("id", txtid.Text);
            dict.Add("Qualification", txtqul.Text);
            dict.Add("Email", txtmail.Text);
            dict.Add("Contact", txtnum.Text);
            //dict.Add(1, new info { name = txtname.Text, qualification = txtqul.Text, email = txtmail.Text});
            string val = "";
            foreach (var item in dict)
            {
                 val += "\n" + item.Value;
               
            }
            MessageBox.Show(val.ToString(),"Dictionary");



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add(txtname.Text);
            hs.Add(txtid.Text);
            hs.Add(txtqul.Text);
            hs.Add(txtmail.Text);
            hs.Add(txtnum.Text);
            string val = "";
            foreach (var item in hs)
            {
                val += "\n" + item;

            }
            MessageBox.Show(val.ToString(), "Hashset");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            

            Stack<string> stk = new Stack<string>();
            stk.Push(txtname.Text);
            stk.Push(txtid.Text);
            stk.Push(txtqul.Text);
            stk.Push(txtmail.Text);
            stk.Push(txtnum.Text);
            string val = "";
            foreach (var item in stk)
            {
                val += "\n" + item;

            }
            MessageBox.Show(val.ToString(), "Stack");
            // int sid = Convert.ToInt32(txtid.Text);
            // int num = Convert.ToInt32(txtnum.Text);
            // stk.Push(new info { id = sid, name=txtname.Text,qualification=txtqul.Text,email=txtmail.Text,contact=num });

            //// string val = "";
            // foreach (var item in stk)
            // {
            //     //val += "\n" + item;
            //     //MessageBox.Show(item.ToString(),"Stack");

            // }
            // // MessageBox.Show(val.ToString(), "Stack");
            // MessageBox.Show(item.ToString(), "Stack");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue(txtname.Text);
            que.Enqueue(txtid.Text);
            que.Enqueue(txtqul.Text);
            que.Enqueue(txtmail.Text);
            que.Enqueue(txtnum.Text);
            string val = "";
            foreach (var item in que)
            {
                val += "\n" + item;

            }
            MessageBox.Show(val.ToString(), "Queue");

        }
    }

    //public class info
    //{
    //    public string name { get; set; }

    //    public int id { get; set; }

    //    public string qualification { get; set; }

    //    public string email { get; set; }

    //    public int contact { get; set; }


    //}

}
