using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loluta_Stefana
{
    public partial class Form2 : Form
    {
        public static string animal;
        public static string rasa;
        public static string talie;
        public static string medie_vr;
        public static string mediu_vi;
        public static string comport;
        public static string hrana;
        public Form2()
        {
            InitializeComponent();
            Caine d1 = new Caine("Amstaff", "mare", 12, "caine de lupte");
            Caine d2 = new Caine("Pomeranian", "mica", 13, "caine de casa");
            Caine d3 = new Caine("Husky", "mare", 13, "caine de vanatoare");
            Caine d4 = new Caine("Bichon", "mica", 10, "caine de casa");
            Caine d5 = new Caine("Cav. King. Charles Spaniel", "medie", 15, "caine de jucarie");
            Pisica c1 = new Pisica("Albastra de Rusia", 6,"eleganta");
            Pisica c2 = new Pisica("Birmaneza", 11, "draguta");
            Pisica c3 = new Pisica("Bombay", 11, "agresiva");
            Pisica c4 = new Pisica("Cornish Rex", 12, "flegmatica");
            Pisica c5 = new Pisica("Burmeza", 13, "inteligenta");
            Pasari b1 = new Pasari("Perus",7);
            Pasari b2 = new Pasari("Papagal cenusiu",9);
            Pasari b3 = new Pasari("Porumbel", 13);
            Pasari b4 = new Pasari("Gaina", 8);
            Pasari b5 = new Pasari("Paun", 14);
            Peste f1 = new Peste("Peste Clown",5);
            Peste f2 = new Peste("Pom-pom", 3);
            Peste f3 = new Peste("Black Telescope", 7);
            Peste f4 = new Peste("Caras cometa", 4);
            Peste f5 = new Peste("Peste Veverita", 3);
            if(Form1.suma>=61)
            {
                label_Animal.Text = "Pisica";
                animal = "Pisica";
                listBox1.Items.Add(string.Join(Environment.NewLine, c1.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, c2.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, c3.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, c4.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, c5.getRasa()));
            }
            else
                if(Form1.suma>=46 && Form1.suma<=60)
            
                {
                    label_Animal.Text = "Caine";
                    animal = "Caine";
                    listBox1.Items.Add(string.Join(Environment.NewLine, d1.getRasa()));
                    listBox1.Items.Add(string.Join(Environment.NewLine, d2.getRasa()));
                    listBox1.Items.Add(string.Join(Environment.NewLine, d3.getRasa()));
                    listBox1.Items.Add(string.Join(Environment.NewLine, d4.getRasa()));
                    listBox1.Items.Add(string.Join(Environment.NewLine, d5.getRasa()));
                }
             
            else
                if(Form1.suma>=30 && Form1.suma<=45)
            {
                label_Animal.Text = "Peste";
                animal = "Peste";
                listBox1.Items.Add(string.Join(Environment.NewLine, f1.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, f2.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, f3.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, f4.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, f5.getRasa()));
            }
            else
            {
                label_Animal.Text = "Pasare";
                animal = "Pasare";
                listBox1.Items.Add(string.Join(Environment.NewLine, b1.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, b2.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, b3.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, b4.getRasa()));
                listBox1.Items.Add(string.Join(Environment.NewLine, b5.getRasa()));
            }

        }

        private void button_Gata_Click(object sender, EventArgs e)
        {
            rasa = listBox1.SelectedItem.ToString();
            Form3 thirdform = new Form3();
            thirdform.Show();
        }
    }
}
