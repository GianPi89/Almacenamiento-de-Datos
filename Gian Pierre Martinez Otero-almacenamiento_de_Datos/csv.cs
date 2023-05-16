using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almacenamientoDeDatos
{
    public partial class frmCsv : Form
    {
        public List<Persona> personas = new List<Persona>();

        public frmCsv()
        {
            InitializeComponent();

            //personas.Add(new Persona(0,"Nombre"));

            leerArchivo();
            llenarArchivo();

            dgvPersonas.DataSource = personas;

            dgvPersonas.Columns["id"].HeaderText = "ID";
            dgvPersonas.Columns["name"].HeaderText = "Nombre";
        }

        public void llenarArchivo()
        {

            StreamWriter sw = new StreamWriter("..\\..\\utils\\personas.csv");

            foreach (Persona p in personas)
            {
                sw.WriteLine($"{p.id},{p.name}");

            }
            sw.Close();
        }

        public void leerArchivo()
        {
            StreamReader sr = new StreamReader("..\\..\\utils\\personas.csv");
            string linea;
            bool idRepetido = false;
            linea = sr.ReadLine();

            while (linea != null)
            {
                string[] vec = linea.Split(',');
                try
                {

                    foreach (Persona p in personas)
                    {
                        if (p.id == Convert.ToInt32(vec[0]))
                        {
                            idRepetido = true;
                        }
                    }

                    if (idRepetido == false)
                    {
                        personas.Add(new Persona(Convert.ToInt32(vec[0]), vec[1]));
                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un Error " + e);
                }

                linea = sr.ReadLine();
            }
            sr.Close();
        }

        private void imgAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal inicio = new frmPrincipal();
            Hide();
            inicio.Show();
        }

        private void frmCsv_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int id = 0;
            bool idRepetido = false;


            if (txtAgregar.Text.Trim() != "")
            {
                do
                {
                    id = n.Next(1000000, 9999999);

                    if (personas.Count > 0)
                    {
                        foreach (Persona p in personas)
                        {
                            if (id == p.id)
                            {
                                idRepetido = true;
                                break;
                            }
                        }
                    }

                } while (idRepetido == true);


                personas.Add(new Persona(id, txtAgregar.Text));
                llenarArchivo();
                MessageBox.Show("Se ha registrado el usuario");
                txtAgregar.Clear();
            }
            else
            {
                MessageBox.Show("Debe agregar el nombre ");
            }

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            bool idEncontrado = false;
            int id = 0;

            if (txtNueID.Text.Trim() == "" || txtNueNombre.Text.Trim() == "")
            {
                MessageBox.Show("Digite ID y su nuevo nombre");
                return;
            }


            foreach (Persona p in personas)
            {

                if (int.TryParse(txtNueID.Text.Trim(), out id) && id == p.id)
                {

                    idEncontrado = true;
                    p.name = txtNueNombre.Text;
                    txtNueNombre.Clear();
                    txtNueID.Clear();

                    MessageBox.Show("El nombre se ha editado");
                }

            }


            if (idEncontrado == false)
            {
                MessageBox.Show("Ingrese un ID correcto");
            }

            llenarArchivo();

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            bool eliminado = false;
            int id = 0;


            foreach (Persona p in personas)
            {

                if (int.TryParse(txtEliminar.Text.Trim(), out id) && id == p.id)
                {

                    eliminado = true;
                    personas.Remove(p);
                    MessageBox.Show("Se han eliminado los datos del usuario");
                    txtEliminar.Clear();
                    llenarArchivo();
                    break;
                }

            }

            if (eliminado == false)
            {
                MessageBox.Show("no se eliminaron los datos del usuario");
            }

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }
    }
}
