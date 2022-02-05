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
    public partial class Form6 : Form
    {
        Thread th;
        public char g;
        public string a, b, c, d, a1, b1, c1, d1;
        bool col4 = false;
        bool miscare = true;
        bool col1 = false;
        bool moare = false;
        bool col2 = false;
        bool col5 = false;
        bool col3 = false;


        private void Alex_KeyDown(object sender, KeyEventArgs e)
        {
            if (miscare == true)
            {
                if (lupp1.Bounds.IntersectsWith(Alex.Bounds) && g == 'd')
                    miscarelupi();
                if (lupp1.Bounds.IntersectsWith(Alex.Bounds) && lup2.IsDisposed == false && g == 'd')
                    miscare = false;
                if (lupp2.Bounds.IntersectsWith(Alex.Bounds) && g == 'd')
                    miscarelupi2();
                if (lupp2.Bounds.IntersectsWith(Alex.Bounds) && lup4.IsDisposed == false && g == 'd')
                    miscare = false;
                if (lupp3.Bounds.IntersectsWith(Alex.Bounds) && g == 'd')
                    miscarelup5();
                if (lupp3.Bounds.IntersectsWith(Alex.Bounds) && lup5.IsDisposed == false && g == 'd')
                    miscare = false;
            }
        }
        private async void miscarelupi()
        {
            int bubu = 0;

            lup1.Size = new Size(70, 48);
            lup2.Size = new Size(70, 48);
            do
            {
                if (bubu % 2 == 0)
                {
                    lup1.Image = Image.FromFile("lup4.png");
                    lup2.Image = Image.FromFile("lup3.png");
                }
                else
                {
                    lup1.Image = Image.FromFile("lup3.png");
                    lup2.Image = Image.FromFile("lup4.png");
                }

                lup1.Left = lup1.Left - 10;
                lup2.Left = lup2.Left - 10;
                await Task.Delay(200);
                bubu++;
                if (lup2.Bounds.IntersectsWith(Alex.Bounds))
                {
                    lup2.Image = Image.FromFile("lup2.png");
                    await Task.Delay(300);

                    if (col2 != true)
                        Haita_de_lupi.caracter.hp = Haita_de_lupi.caracter.hp - 1;
                    damage();
                    lup2.Dispose();
                    col2 = true;

                }

                if (lup1.Bounds.IntersectsWith(Alex.Bounds))
                {
                    lup1.Image = Image.FromFile("lup2.png");
                    await Task.Delay(300);
                    if (col1 != true)
                        Haita_de_lupi.caracter.hp = Haita_de_lupi.caracter.hp - 1;

                    damage();
                    lup1.Dispose();
                    col1 = true;

                }
                if (col1 == true && col2 == true)
                    miscare = true;



            } while (lup2.Left > -300);
            miscare = true;


            lup1.Dispose();
            lup2.Dispose();
        }

        private async void Alex_KeyPress(object sender, KeyPressEventArgs e)
        {
            int v = 5;
            int vg = 10;

            if (miscare == false)
                v = Convert.ToInt32(v * caracter.frica);

            if (e.KeyChar == 'w')
            {
                Alex.Top = Alex.Top - v;
                Alex.Image = System.Drawing.Image.FromFile(a);
                g = e.KeyChar;
            }
            if (e.KeyChar == 's')
            {
                Alex.Top = Alex.Top + v;
                Alex.Image = System.Drawing.Image.FromFile(b);
                g = e.KeyChar;
            }
            if (e.KeyChar == 'a')
            {
                Alex.Left = Alex.Left - v;
                Alex.Image = System.Drawing.Image.FromFile(c);
                g = e.KeyChar;
            }
            if (e.KeyChar == 'd')
            {
                Alex.Left = Alex.Left + v;
                Alex.Image = System.Drawing.Image.FromFile(d);
                g = e.KeyChar;
            }

            if (Alex.Bounds.IntersectsWith(hitbox1.Bounds) || Alex.Bounds.IntersectsWith(hitbox2.Bounds) || Alex.Bounds.IntersectsWith(hitbox3.Bounds) || Alex.Bounds.IntersectsWith(hitbox4.Bounds) || Alex.Bounds.IntersectsWith(hitbox5.Bounds) || Alex.Bounds.IntersectsWith(hitbox6.Bounds) ||  Alex.Left <= 0 || Alex.Top >= 530 || Alex.Top <= 0)
            {
                if (e.KeyChar == 'w')
                    Alex.Top = Alex.Top + v;
                if (e.KeyChar == 's')
                    Alex.Top = Alex.Top - v;
                if (e.KeyChar == 'a')
                    Alex.Left = Alex.Left + v;
                if (e.KeyChar == 'd')
                    Alex.Left = Alex.Left - v;
            }
            if (Alex.Bounds.IntersectsWith(finish.Bounds))
            {
                this.Close();
                th = new Thread(newform7);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            if (e.KeyChar == 32)
            {
                PictureBox glont = new PictureBox();
                glont.Size = new Size(25, 25);
                glont.Left = Alex.Left + 10;
                glont.Top = Alex.Top + 10;
                this.Controls.Add(glont);


                if (g == 'w')
                {
                    glont.Size = new Size(15, 48);
                    glont.Image = System.Drawing.Image.FromFile(a1);
                    glont.BackColor = Color.Transparent;
                    do
                    {
                        glont.Top = glont.Top - vg;
                        await Task.Delay(50);

                    } while (glont.Top > -75);
                    glont.Dispose();
                }
                if (g == 'a')
                {
                    glont.Size = new Size(48, 15);
                    glont.Image = System.Drawing.Image.FromFile(c1);
                    glont.BackColor = Color.Transparent;

                    do
                    {
                        glont.Left = glont.Left - vg;
                        await Task.Delay(50);

                    } while (glont.Left > -100);
                    glont.Dispose();
                }
                if (g == 's')
                {
                    glont.Size = new Size(15, 48);
                    glont.Image = System.Drawing.Image.FromFile(b1);
                    glont.BackColor = Color.Transparent;
                    do
                    {
                        glont.Top = glont.Top + vg;
                        await Task.Delay(50);

                    } while (glont.Top < 800);
                    glont.Dispose();
                }
                if (g == 'd')
                {
                    glont.Size = new Size(48, 15);
                    glont.Image = System.Drawing.Image.FromFile(d1);
                    glont.BackColor = Color.Transparent;
                    do
                    {
                        glont.Left = glont.Left + vg;
                        await Task.Delay(50);
                        if (glont.Bounds.IntersectsWith(lup1.Bounds) && !lup1.IsDisposed)
                        {
                            if (!glont.IsDisposed)
                            {
                                lup1.Dispose();
                                col1 = true;
                            }

                            glont.Dispose();
                        }
                        if (glont.Bounds.IntersectsWith(lup2.Bounds) && !lup2.IsDisposed)
                        {
                            if (!glont.IsDisposed)
                            {
                                lup2.Dispose();
                                col2 = true;
                            }

                            glont.Dispose();
                        }
                        if (glont.Bounds.IntersectsWith(lup3.Bounds) && !lup3.IsDisposed)
                        {
                            if (!glont.IsDisposed)
                            {
                                lup3.Dispose();
                                col3 = true;
                            }

                            glont.Dispose();
                        }
                        if (glont.Bounds.IntersectsWith(lup4.Bounds) && !lup4.IsDisposed)
                        {
                            if (!glont.IsDisposed)
                            {
                                lup4.Dispose();
                                col4 = true;
                            }

                            glont.Dispose();
                        }
                        if (glont.Bounds.IntersectsWith(lup5.Bounds) && !lup5.IsDisposed)
                        {
                            if (!glont.IsDisposed)
                            {
                                lup5.Dispose();
                                col5 = true;
                            }

                            glont.Dispose();
                        }
                    } while (glont.Left < 1350);
                    glont.Dispose();
                }


            }
        }

        private void Alex_Click(object sender, EventArgs e)
        {

        }

        private async void miscarelupi2()
        {
            int bubu = 0;

            lup1.Size = new Size(70, 48);
            lup2.Size = new Size(70, 48);
            do
            {
                if (bubu % 2 == 0)
                {
                    lup3.Image = Image.FromFile("lup4.png");
                    lup4.Image = Image.FromFile("lup3.png");
                }
                else
                {
                    lup3.Image = Image.FromFile("lup3.png");
                    lup4.Image = Image.FromFile("lup4.png");
                }

                lup3.Left = lup3.Left - 10;
                lup4.Left = lup4.Left - 10;
                await Task.Delay(200);
                bubu++;
                if (lup3.Bounds.IntersectsWith(Alex.Bounds))
                {
                    lup3.Image = Image.FromFile("lup2.png");
                    await Task.Delay(300);

                    if (col3 != true)
                        Haita_de_lupi.caracter.hp = Haita_de_lupi.caracter.hp - 1;
                    damage();
                    lup3.Dispose();
                    col3 = true;

                }

                if (lup4.Bounds.IntersectsWith(Alex.Bounds))
                {
                    lup4.Image = Image.FromFile("lup2.png");
                    await Task.Delay(300);
                    if (col4 != true)
                        Haita_de_lupi.caracter.hp = Haita_de_lupi.caracter.hp - 1;

                    damage();
                    lup4.Dispose();
                    col4 = true;

                }
                if (col4 == true && col3 == true)
                    miscare = true;



            } while (lup4.Left > -300);
            miscare = true;


            lup4.Dispose();
            lup3.Dispose();
        }
        private async void miscarelup5()
        {
            int bubu = 0;


            lup5.Size = new Size(70, 48);

            do
            {
                if (bubu % 2 == 0)
                {
                    lup5.Image = Image.FromFile("lup4.png");

                }
                else
                {
                    lup5.Image = Image.FromFile("lup3.png");

                }

                lup5.Left = lup5.Left - 5;

                await Task.Delay(200);
                bubu++;


                if (lup5.Bounds.IntersectsWith(Alex.Bounds))
                {
                    lup5.Image = Image.FromFile("lup2.png");
                    await Task.Delay(300);
                    if (col5 != true)
                        Haita_de_lupi.caracter.hp = Haita_de_lupi.caracter.hp - 1;

                    damage();
                    lup5.Dispose();
                    col5 = true;

                }
                if (col5 == true)
                    miscare = true;



            } while (lup5.Left > -300);
            miscare = true;


            lup5.Dispose();

        }
        private async void damage()
        {


            if (Haita_de_lupi.caracter.hp < 3)
                inima3.Dispose();
            if (Haita_de_lupi.caracter.hp < 2)
                inima2.Dispose();
            if (Haita_de_lupi.caracter.hp < 1)
            {
                inima1.Dispose();
                await Task.Delay(300);
                if (!moare)
                {
                    mort();
                    moare = true;
                }

            }
        }
        private void mort()
        {
            this.Close();
            th = new Thread(newform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void newform()
        {
            Application.Run(new mort());
        }
        private void newform7()
        {
            Application.Run(new Form7());
        }

        public Form6()
        {
            InitializeComponent();
            Alex.FlatStyle = FlatStyle.Flat;
            Alex.FlatAppearance.BorderSize = 0;
            finish.FlatStyle = FlatStyle.Flat;
            finish.FlatAppearance.BorderSize = 0;


            damage();
            if (Haita_de_lupi.caracter.baiat == true)
            {
                a = "w2.png";
                b = "s2.png";
                c = "a2.png";
                d = "d2.png";
                a1 = "pw1.png";
                b1 = "ps1.png";
                c1 = "pa1.png";
                d1 = "pd1.png";
                finish.Image = Image.FromFile("s1.png");
            }
            else
            {
                a = "w1.png";
                b = "s1.png";
                c = "a1.png";
                d = "d1.png";
                a1 = "pw2.png";
                b1 = "ps2.png";
                c1 = "pa2.png";
                d1 = "pd2.png";
                finish.Image = Image.FromFile("s2.png");

            }
        }

        
    }
}
