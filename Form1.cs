using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorWithClass
{
    public partial class Form1 : Form
    {
        calculator calcul = new calculator(); //creating the class
        public Form1()
        {
            InitializeComponent();
        }
      
       
        private void Btn_add_Click(object sender, EventArgs e)
        {
            txt_result.Text = calcul.add(txt_num1.Text, txt_num2.Text); // call addd function
        }

        private void Btn_sub_Click(object sender, EventArgs e)
        {
            txt_result.Text = calcul.sub(txt_num1.Text, txt_num2.Text); // call subraction function
        }

        private void Btn_multi_Click(object sender, EventArgs e)
        {
            txt_result.Text = calcul.mul(txt_num1.Text, txt_num2.Text); //call multipilication function
        }

        private void Btn_divi_Click(object sender, EventArgs e)
        {
            txt_result.Text = calcul.div(txt_num1.Text, txt_num2.Text); // call division fucntion
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e) //exit code
        {
            this.Close();
        }
    }
}
