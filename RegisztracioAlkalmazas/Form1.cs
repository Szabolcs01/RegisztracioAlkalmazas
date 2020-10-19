using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   
private void btnHozzaad_Click(object sender, EventArgs e)
        {
            string hobbi = textBoxHobbi.Text;
            if (String.IsNullOrWhiteSpace(hobbi))
            {
                MessageBox.Show("Nincs semmi meg adva");
                textBoxHobbi.Text = " ";
                textBoxHobbi.Focus();
                return;
            }
            if (listBoxLista.Items.Contains(hobbi))
            {
                MessageBox.Show("Ez már szerepel!");
                textBoxHobbi.Text = "";
                textBoxHobbi.Focus();
                return;
            }
           listBoxLista.Items.Add(hobbi.TrimStart().TrimEnd());
            textBoxHobbi.Text = " ";
            textBoxHobbi.Focus();
        }
    }
}
