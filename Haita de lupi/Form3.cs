using System;
using System.Threading;
using System.Windows.Forms;

namespace Haita_de_lupi
{
    public partial class mort : Form
    {
        Thread th;
        public mort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(newform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void newform()
        {
            Application.Run(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
