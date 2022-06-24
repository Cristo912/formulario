using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;

namespace HerenciasyObjetos
{
    public partial class Form1 : Form
    {
        Director mydirector = new Director();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngualdal_Click(object sender, EventArgs e)
        {
      
            mydirector.ci = Convert.ToInt32(txtci.Text);
            mydirector.nombre = txtnombre.Text;
            mydirector.segundo_nombre = txtsegundo_nombre.Text;
            mydirector.apellido = txtapellido.Text;
            mydirector.segundo_apellido = txtsegundo_apellido.Text;
            mydirector.email = txtemail.Text;
            mydirector.telefono = Convert.ToInt32(txttelefono.Text);

        }
    }
}
