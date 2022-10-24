using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loluta_Stefana
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Caine d1 = new Caine("Amstaff", "mare", 12, "caine de lupte");
            Caine d2 = new Caine("Pomeranian", "mica", 13, "caine de casa");
            Caine d3 = new Caine("Husky", "mare", 13, "caine de vanatoare");
            Caine d4 = new Caine("Bichon", "mica", 10, "caine de casa");
            Caine d5 = new Caine("Cav. King. Charles Spaniel", "medie", 15, "caine de jucarie");
            Pisica c1 = new Pisica("Albastra de Rusia", 6, "eleganta");
            Pisica c2 = new Pisica("Birmaneza", 11, "draguta");
            Pisica c3 = new Pisica("Bombay", 11, "agresiva");
            Pisica c4 = new Pisica("Cornish Rex", 12, "flegmatica");
            Pisica c5 = new Pisica("Burmeza", 13, "inteligenta");
            Pasari b1 = new Pasari("Perus", 7);
            Pasari b2 = new Pasari("Papagal cenusiu", 9);
            Pasari b3 = new Pasari("Porumbel", 13);
            Pasari b4 = new Pasari("Gaina", 8);
            Pasari b5 = new Pasari("Paun", 14);
            Peste f1 = new Peste("Peste Clown", 5);
            Peste f2 = new Peste("Pom-pom", 3);
            Peste f3 = new Peste("Black Telescope", 7);
            Peste f4 = new Peste("Caras cometa", 4);
            Peste f5 = new Peste("Peste Veverita", 3);
            if (Form2.rasa== "Amstaff")
            {

                pictureBox1.ImageLocation = "amstaff.jpg";
                pictureBox1.SizeMode= PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = d1.getTalie();
                textBox_medie_varsta.Text = d1.getMedieVarsta();
                textBox_mediu_viata.Text = d1.getMediuViata();
                textBox_coportament.Text = d1.getComportament();
                textBox_hrana.Text = d1.getHrana();
            }
            else
                if(Form2.rasa == "Pomeranian")
            {
                pictureBox1.ImageLocation = "pomeranian.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = d2.getTalie();
                textBox_medie_varsta.Text = d2.getMedieVarsta();
                textBox_mediu_viata.Text = d2.getMediuViata();
                textBox_coportament.Text = d2.getComportament();
                textBox_hrana.Text = d2.getHrana();
            }
            if (Form2.rasa == "Husky")
            {
                pictureBox1.ImageLocation = "husky.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = d3.getTalie();
                textBox_medie_varsta.Text = d3.getMedieVarsta();
                textBox_mediu_viata.Text = d3.getMediuViata();
                textBox_coportament.Text = d3.getComportament();
                textBox_hrana.Text = d3.getHrana();
            }
            if (Form2.rasa == "Bichon")
            {
                pictureBox1.ImageLocation = "bichon.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = d4.getTalie();
                textBox_medie_varsta.Text = d4.getMedieVarsta();
                textBox_mediu_viata.Text = d4.getMediuViata();
                textBox_coportament.Text = d4.getComportament();
                textBox_hrana.Text = d4.getHrana();
            }
            if (Form2.rasa == "Cav. King. Charles Spaniel")
            {
                pictureBox1.ImageLocation = "cavalier.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = d5.getTalie();
                textBox_medie_varsta.Text = d5.getMedieVarsta();
                textBox_mediu_viata.Text = d5.getMediuViata();
                textBox_coportament.Text = d5.getComportament();
                textBox_hrana.Text = d5.getHrana();
            }
            if (Form2.rasa == "Albastra de Rusia")
            {
                pictureBox1.ImageLocation = "albastra.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = c1.getTalie();
                textBox_medie_varsta.Text = c1.getMedieVarsta();
                textBox_mediu_viata.Text = c1.getMediuViata();
                textBox_coportament.Text = c1.getComportament();
                textBox_hrana.Text = c1.getHrana();
            }
            if (Form2.rasa == "Birmaneza")
            {
                pictureBox1.ImageLocation = "birmaneza.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = c2.getTalie();
                textBox_medie_varsta.Text = c2.getMedieVarsta();
                textBox_mediu_viata.Text = c2.getMediuViata();
                textBox_coportament.Text = c2.getComportament();
                textBox_hrana.Text = c2.getHrana();
            }
            if (Form2.rasa == "Bombay")
            {
                pictureBox1.ImageLocation = "bombay.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = c1.getTalie();
                textBox_medie_varsta.Text = c3.getMedieVarsta();
                textBox_mediu_viata.Text = c3.getMediuViata();
                textBox_coportament.Text = c3.getComportament();
                textBox_hrana.Text = c3.getHrana();
            }
            if (Form2.rasa == "Cornish Rex")
            {
                pictureBox1.ImageLocation = "cornish.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = c4.getTalie();
                textBox_medie_varsta.Text = c4.getMedieVarsta();
                textBox_mediu_viata.Text = c4.getMediuViata();
                textBox_coportament.Text = c4.getComportament();
                textBox_hrana.Text = c4.getHrana();
            }
            if (Form2.rasa == "Burmeza")
            {
                pictureBox1.ImageLocation = "burmeza.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = c5.getTalie();
                textBox_medie_varsta.Text = c5.getMedieVarsta();
                textBox_mediu_viata.Text = c5.getMediuViata();
                textBox_coportament.Text = c5.getComportament();
                textBox_hrana.Text = c5.getHrana();
            }
            if (Form2.rasa == "Perus")
            {
                pictureBox1.ImageLocation = "perus.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = b1.getTalie();
                textBox_medie_varsta.Text = b1.getMedieVarsta();
                textBox_mediu_viata.Text = b1.getMediuViata();
                textBox_coportament.Text = b1.getComportament();
                textBox_hrana.Text = b1.getHrana();
            }
            if (Form2.rasa == "Papagal cenusiu")
            {
                pictureBox1.ImageLocation = "papagal.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = b2.getTalie();
                textBox_medie_varsta.Text = b2.getMedieVarsta();
                textBox_mediu_viata.Text = b2.getMediuViata();
                textBox_coportament.Text = b2.getComportament();
                textBox_hrana.Text = b2.getHrana();
            }
            if (Form2.rasa == "Porumbel")
            {
                pictureBox1.ImageLocation = "porumbel.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = b3.getTalie();
                textBox_medie_varsta.Text = b3.getMedieVarsta();
                textBox_mediu_viata.Text = b3.getMediuViata();
                textBox_coportament.Text = b3.getComportament();
                textBox_hrana.Text = b3.getHrana();
            }
            if (Form2.rasa == "Gaina")
            {
                pictureBox1.ImageLocation = "gaina.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = b4.getTalie();
                textBox_medie_varsta.Text = b4.getMedieVarsta();
                textBox_mediu_viata.Text = b4.getMediuViata();
                textBox_coportament.Text = b4.getComportament();
                textBox_hrana.Text = b4.getHrana();
            }
            if (Form2.rasa == "Paun")
            {
                pictureBox1.ImageLocation = "paun.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = b5.getTalie();
                textBox_medie_varsta.Text = b5.getMedieVarsta();
                textBox_mediu_viata.Text = b5.getMediuViata();
                textBox_coportament.Text = b5.getComportament();
                textBox_hrana.Text = b5.getHrana();
            }
            if (Form2.rasa == "Peste Clown")
            {
                pictureBox1.ImageLocation = "pesteclown.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = f1.getTalie();
                textBox_medie_varsta.Text = f1.getMedieVarsta();
                textBox_mediu_viata.Text = f1.getMediuViata();
                textBox_coportament.Text = f1.getComportament();
                textBox_hrana.Text = f1.getHrana();
            }
            if (Form2.rasa == "Pom-pom")
            {
                pictureBox1.ImageLocation = "pompom.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = f2.getTalie();
                textBox_medie_varsta.Text = f2.getMedieVarsta();
                textBox_mediu_viata.Text = f2.getMediuViata();
                textBox_coportament.Text = f2.getComportament();
                textBox_hrana.Text = f2.getHrana();
            }
            if (Form2.rasa == "Black Telescope")
            {
                pictureBox1.ImageLocation = "blacktelescope.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = f3.getTalie();
                textBox_medie_varsta.Text = f3.getMedieVarsta();
                textBox_mediu_viata.Text = f3.getMediuViata();
                textBox_coportament.Text = f3.getComportament();
                textBox_hrana.Text = f3.getHrana();
            }
            if (Form2.rasa == "Caras cometa")
            {
                pictureBox1.ImageLocation = "caras.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = f4.getTalie();
                textBox_medie_varsta.Text = f4.getMedieVarsta();
                textBox_mediu_viata.Text = f4.getMediuViata();
                textBox_coportament.Text = f4.getComportament();
                textBox_hrana.Text = f4.getHrana();
            }
            else
                if(Form2.rasa== "Peste Veverita")
            {
                pictureBox1.ImageLocation = "pesteveverita.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                textBox_animal.Text = Form2.animal;
                textBox_rasa.Text = Form2.rasa;
                textBox_talie.Text = f5.getTalie();
                textBox_medie_varsta.Text = f5.getMedieVarsta();
                textBox_mediu_viata.Text = f5.getMediuViata();
                textBox_coportament.Text = f5.getComportament();
                textBox_hrana.Text = f5.getHrana();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
