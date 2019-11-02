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

    
    public partial class Form1 : Form
    {
        string tekst = "Hello world";
        public Form1()
        {
            
            InitializeComponent();
            txtOkno1.Text = tekst;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Owner = this;
            form2.ShowDialog();
            
            //cos sobie pisze NIE WIEM CO
        }

    }


}
