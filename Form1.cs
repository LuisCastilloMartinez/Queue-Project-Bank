using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ED_P5U3_COLAS
{
    public partial class Form1 : KryptonForm
    {
        int total = 0;
        Random num = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (total == 5)
                MessageBox.Show("La cola esta llena");
            else
            {
                total++;
                txtTotal.Text = Convert.ToString(total);

                switch(total)
                {
                    case 1:
                        txtN1.Text = Convert.ToString(num.Next(1,99));
                        txtN1.Visible = true;
                        break;
                    case 2:
                        txtN2.Text = Convert.ToString(num.Next(1, 99));
                        txtN2.Visible = true;
                        break;
                    case 3:
                        txtN3.Text = Convert.ToString(num.Next(1, 99));
                        txtN3.Visible = true;
                        break;
                    case 4:
                        txtN4.Text = Convert.ToString(num.Next(1, 99));
                        txtN4.Visible = true;
                        break;
                    case 5:
                        txtN5.Text = Convert.ToString(num.Next(1, 99));
                        txtN5.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Error en la cola");
                        break;
                }
                timer1.Enabled = true;
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if (total == 0)
                MessageBox.Show("Cola vacia, no puede eliminar dato");
            else
            {
                txtN1.Text = txtN2.Text;
                txtN2.Text = txtN3.Text;
                txtN3.Text = txtN4.Text;
                txtN4.Text = txtN5.Text;

                if (total == 1) txtN1.Visible = false;
                if (total == 2) txtN2.Visible = false;
                if (total == 3) txtN3.Visible = false;
                if (total == 4) txtN4.Visible = false;
                if (total == 5) txtN5.Visible = false;
                total--;
                txtTotal.Text = Convert.ToString(total);
                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
            if(total == 1)
            {
                pb1.Left = pb1.Left + 5;
                if (pb1.Left >= 300) timer1.Enabled = false;
            }
            if (total == 2)
            {
                pb2.Left = pb2.Left + 5;
                if (pb2.Left >= 250) timer1.Enabled = false;
            }
            if (total == 3)
            {
                pb3.Left = pb3.Left + 5;
                if (pb3.Left >= 200) timer1.Enabled = false;
            }
            if (total == 4)
            {
                pb4.Left = pb4.Left + 5;
                if (pb4.Left >= 150) timer1.Enabled = false;
            }
            if (total == 5)
            {
                pb5.Left = pb5.Left + 5;
                if (pb5.Left >= 100) timer1.Enabled = false;
            }
            if (timer1.Enabled == false) btnIngresar.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnExtraer.Enabled = false;
            pb1.Left = pb1.Left + 5;
            if (pb1.Left >= 600)
            {
                pb1.Left = 300;
                if (total == 4) pb5.Left = -50;
                if (total == 3) pb4.Left = -50;
                if (total == 2) pb3.Left = -50;
                if (total == 1) pb2.Left = -50;
                if (total == 0) pb1.Left = -50;
                timer2.Enabled = false;
            }
            if (timer2.Enabled == false) btnExtraer.Enabled = true;
        }
    }
}
