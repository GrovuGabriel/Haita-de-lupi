using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Haita_de_lupi
{
    
    public partial class button : Form
    {
       
        Thread th;
        public button()
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        public string a = "w2.png", b = "s2.png", c = "a2.png", d = "d2.png";
        public string a1 = "pw1.png", b1 = "ps1.png", c1 = "pa1.png", d1 = "pd1.png";
        public char g;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void instructiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (instructiuniToolStripMenuItem.Checked == false)
            {
                instructiuniToolStripMenuItem.Checked = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label1.Visible = true;
                if (caracter.baiat)
                    label2.Visible = true;
                else
                    label3.Visible = true;
            }
            else
            { instructiuniToolStripMenuItem.Checked = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(newform5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void newform2()
        {
            Application.Run(new Form2());
           
        }

        private void campanieUsorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caracter.usor = true;
            this.Close();
            th = new Thread(newform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void campanieGreuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caracter.usor = false;
            this.Close();
            th = new Thread(newform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newform5()
        {
            Application.Run(new Form7());
        }


        private void baiatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = "w2.png";
            b = "s2.png";
            c = "a2.png";
            d = "d2.png";
            a1 = "pw1.png";
            b1 = "ps1.png";
            c1 = "pa1.png";
            d1 = "pd1.png";
            caracter.baiat = true;
            button1.Image = Image.FromFile("s2.png");
            if(instructiuniToolStripMenuItem.Checked == true)
            {
                label2.Visible = true;
                label3.Visible = false;
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void fataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = "w1.png";
            b = "s1.png";
            c = "a1.png";
            d = "d1.png";
            a1 = "pw2.png";
            b1 = "ps2.png";
            c1 = "pa2.png";
            d1 = "pd2.png";
            caracter.baiat = false;
            button1.Image = Image.FromFile("s1.png");
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            if (instructiuniToolStripMenuItem.Checked == true)
            {
                label3.Visible = true;
                label2.Visible = false;
            }

        }
        
        public bool tras = false;
        private async void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int v = 5;
            int vg = 10;
            

            if (e.KeyChar == 'w')
            {
                button1.Top = button1.Top - v;
                button1.Image = System.Drawing.Image.FromFile(a);
                g = e.KeyChar;
            }
            if (e.KeyChar == 's')
            {
                button1.Top = button1.Top + v;
                button1.Image = System.Drawing.Image.FromFile(b);
                g = e.KeyChar;
            }
            if (e.KeyChar == 'a')
            {
                button1.Left = button1.Left - v;
                button1.Image = System.Drawing.Image.FromFile(c);
                g = e.KeyChar;
            }
            if (e.KeyChar == 'd')
            {
                button1.Left = button1.Left + v;
                button1.Image = System.Drawing.Image.FromFile(d);
                g = e.KeyChar;
            }

            
            
            if (e.KeyChar == 32)
            {
               
                PictureBox glont = new PictureBox();
                glont.Size = new Size(25, 25);
                glont.Left = button1.Left + 10;
                glont.Top = button1.Top + 10;
                this.Controls.Add(glont);

                if (g == 'w')
                {
                    glont.Size = new Size(15, 48);
                    glont.Image = System.Drawing.Image.FromFile(a1);
                    glont.BackColor = Color.Transparent;
                    
                    do
                    {
                        glont.Top -= vg;
                        await Task.Delay(50);
                    } while (glont.Top>-75);
                    glont.Dispose();
                 }
                if (g == 'a')
                {
                    glont.Size = new Size(48, 15);
                    glont.Image = System.Drawing.Image.FromFile(c1);
                    glont.BackColor = Color.Transparent;
                    
                    do
                    {
                        glont.Left -= vg;
                        await Task.Delay(50);
                    } while (glont.Left >-100);
                    glont.Dispose();
                }
                if (g == 's')
                {
                    glont.Size = new Size(15, 48);
                    glont.Image = System.Drawing.Image.FromFile(b1);
                    glont.BackColor = Color.Transparent;
                    
                    do
                    {
                        glont.Top += vg;
                        await Task.Delay(50);
                    } while (glont.Top < 600);
                    glont.Dispose();
                }
                if (g == 'd')
                {
                    glont.Size = new Size(48,15);
                    glont.Image = System.Drawing.Image.FromFile(d1);
                    glont.BackColor = Color.Transparent;
                   
                    do
                    {
                        glont.Left += vg;
                        await Task.Delay(50);
                    } while (glont.Left < 750);
                    glont.Dispose();
                }
                


                

            }
        }

        
    }
}