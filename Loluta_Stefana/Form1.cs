using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loluta_Stefana
{
    public partial class Form1 : Form
    {
        public static int suma;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            suma = 0;
            if (checkBox_I1_aer.Checked == true)
                suma = suma + 5;
            else
                if (checkBox_I1_Apa.Checked == true)
                suma = suma + 10;
            else
                    if (checkBox_I1_foc.Checked == true)
                suma = suma + 20;
            else
                        if (checkBox_I1_pam.Checked == true)
                suma = suma + 15;


            if (checkBox_I2_acasa.Checked == true)
                suma = suma + 5;
            else
                if (checkBox_I2_mare.Checked == true)
                suma = suma + 20;
            else
                    if (checkBox_I2_munte.Checked == true)
                suma = suma + 15;
            else
                   if (checkBox_I2_pisc.Checked == true)
                suma = suma + 10;

            if (checkBox_I3_alb.Checked == true)
                suma = suma + 10;
            else
                if (checkBox_I3_gri.Checked == true)
                suma = suma + 5;
            else
                if (checkBox_I3_rosu.Checked == true)
                suma = suma + 20;
            else
                if (checkBox_I3_verde.Checked == true)
                suma = suma + 15;

            if (checkBox_I4_calm.Checked == true)
                suma = suma + 10;
            else
                if (checkBox_I4_indep.Checked == true)
                suma = suma + 5;
            else
                if (checkBox_I4_ling.Checked == true)
                suma = suma + 20;
            else
                if (checkBox_I4_priet.Checked == true)
                suma = suma + 15;
            Form2 secondform = new Form2();
            secondform.Show();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I2_pisc.Checked == true)
            {
                checkBox_I2_munte.Checked = false;
                checkBox_I2_mare.Checked = false;
                checkBox_I2_acasa.Checked = false;
            }
        }

        private void checkBox_I4_indep_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I4_indep.Checked == true)
            {
                checkBox_I4_calm.Checked = false;
                checkBox_I4_ling.Checked = false;
                checkBox_I4_priet.Checked = false;
            }
        }

        private void checkBox_I1_aer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I1_aer.Checked == true)
            {
                checkBox_I1_Apa.Checked = false;
                checkBox_I1_foc.Checked = false;
                checkBox_I1_pam.Checked = false;

            }
        }

        private void checkBox_I1_Apa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I1_Apa.Checked == true)
            {
                checkBox_I1_aer.Checked = false;
                checkBox_I1_foc.Checked = false;
                checkBox_I1_pam.Checked = false;

            }
        }

        private void checkBox_I1_foc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I1_foc.Checked == true)
            {
                checkBox_I1_Apa.Checked = false;
                checkBox_I1_aer.Checked = false;
                checkBox_I1_pam.Checked = false;

            }
        }

        private void checkBox_I1_pam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I1_pam.Checked == true)
            {
                checkBox_I1_Apa.Checked = false;
                checkBox_I1_foc.Checked = false;
                checkBox_I1_aer.Checked = false;

            }
        }

        private void checkBox_I2_munte_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I2_munte.Checked == true)
            {
                checkBox_I2_mare.Checked = false;
                checkBox_I2_pisc.Checked = false;
                checkBox_I2_acasa.Checked = false;
            }
        }

        private void checkBox_I2_mare_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I2_mare.Checked == true)
            {
                checkBox_I2_munte.Checked = false;
                checkBox_I2_pisc.Checked = false;
                checkBox_I2_acasa.Checked = false;
            }
        }

        private void checkBox_I2_acasa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I2_acasa.Checked == true)
            {
                checkBox_I2_munte.Checked = false;
                checkBox_I2_mare.Checked = false;
                checkBox_I2_pisc.Checked = false;
            }
        }

        private void checkBox_I3_rosu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I3_rosu.Checked == true)
            {
                checkBox_I3_gri.Checked = false;
                checkBox_I3_alb.Checked = false;
                checkBox_I3_verde.Checked = false;
            }
        }

        private void checkBox_I3_alb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I3_alb.Checked == true)
            {
                checkBox_I3_gri.Checked = false;
                checkBox_I3_rosu.Checked = false;
                checkBox_I3_verde.Checked = false;
            }
        }

        private void checkBox_I3_verde_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I3_verde.Checked == true)
            {
                checkBox_I3_gri.Checked = false;
                checkBox_I3_rosu.Checked = false;
                checkBox_I3_alb.Checked = false;
            }
        }

        private void checkBox_I3_gri_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I3_gri.Checked == true)
            {
                checkBox_I3_alb.Checked = false;
                checkBox_I3_rosu.Checked = false;
                checkBox_I3_verde.Checked = false;
            }
        }

        private void checkBox_I4_priet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I4_priet.Checked == true)
            {
                checkBox_I4_indep.Checked = false;
                checkBox_I4_ling.Checked = false;
                checkBox_I4_calm.Checked = false;
            }
        }

        private void checkBox_I4_calm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I4_calm.Checked == true)
            {
                checkBox_I4_indep.Checked = false;
                checkBox_I4_ling.Checked = false;
                checkBox_I4_priet.Checked = false;
            }
        }

        private void checkBox_I4_ling_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I4_ling.Checked == true)
            {
                checkBox_I4_indep.Checked = false;
                checkBox_I4_calm.Checked = false;
                checkBox_I4_priet.Checked = false;
            }
        }
    }
}