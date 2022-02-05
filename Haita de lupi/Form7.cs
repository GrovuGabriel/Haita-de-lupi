using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Haita_de_lupi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
           
            InitializeComponent();
            
        }

        Thread th;

        private void button1_Click(object sender, EventArgs e)
        {
            if(caracter.usor==true)
               caracter.usor = false;
            caracter.frica = 0.5;
            this.Close();
            th = new Thread(newform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            

        }
        private void newform2()
        {
            Application.Run(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (caracter.usor == false)
                button1.Text = "Incearca din nou"; 
        }
    }
}
