using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadoravuelto
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void btn_vuelto_Click(object sender, EventArgs e)
        {
            
            int monto = Convert.ToInt32(textBox1.Text);
            int valor = Convert.ToInt32(textBox2.Text);
            int cambio = monto - valor;
           

            //calcular cantidad de billetes
            
            int billetesde2000 = cambio / 2000;
            cambio %= 2000;
            int billetesde1000 = cambio / 1000;
            cambio %= 1000;
            int billetesde500 = cambio / 500;
            cambio %= 500;
            int billetesde200 = cambio / 200;
            cambio %= 200;
            int billetesde100 = cambio / 100;
            cambio %= 100;
            int billetesde50 = cambio / 50;
            cambio %= 50;
            int billetesde20 = cambio / 20;
            cambio %= 20;
            int billetesde10 = cambio / 10;
            cambio %= 10;
            int billetesde5 = cambio / 5;
            cambio %= 5;
            int monedasde2 = cambio / 2;
            cambio %= 2;
            int monedasde1 = cambio / 1;
            cambio %= 1;

            cambio = monto - valor;


            lbl_resul.Text = "El vuelto es: $" + cambio + "\n" + "\n" +
            "La cantidad de billetes de 2000 es " + billetesde2000 + "\n" + 
            "La cantidad de billetes de 1000 es " + billetesde1000 + "\n" +
            "La cantidad de billetes de 500 es " + billetesde500 + "\n" +
            "La cantidad de billetes de 200 es " + billetesde200 + "\n" +
            "La cantidad de billetes de 100 es " + billetesde100 + "\n" +
             "La cantidad de billetes de 50 es " + billetesde50 + "\n" +
             "La cantidad de billetes de 20 es " + billetesde20 + "\n" +
             "La cantidad de billetes de 10 es " + billetesde10 + "\n" +
             "La cantidad de billetes de 5 es " + billetesde5 + "\n" +
             "La cantidad de monedas de 2 es " + monedasde2 + "\n" +
             "La cantidad de monedas de 1 es " + monedasde1;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void lbl_montoingresado_Click(object sender, EventArgs e)
        {

        }
    }
}
