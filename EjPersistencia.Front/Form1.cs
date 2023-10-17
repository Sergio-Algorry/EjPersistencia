using EjPersistencia.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjPersistencia.Front
{
    public partial class Form1 : Form
    {
        Personas ListaPersonas { get; set; } = new Personas();


        public Form1()
        {
            InitializeComponent();
            dg.DataSource = ListaPersonas.ListaDT;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            per.Agregar(ListaPersonas.ListaDT.Rows.Count+1,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtEdad.Text);

            ListaPersonas.InsertPersona(per);
            txtId.Text = per.Id.ToString();
        }
    }
}
