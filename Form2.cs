using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dwa_okna
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            txtOkno2.Text = form1.txtOkno1.Text;
            form1.Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)


        {
            //do git
            int a = 0;
            a = a + 1;

            Application.Exit();
        }
    }
}
