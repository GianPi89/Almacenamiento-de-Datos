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
using System.Xml.Linq;

namespace almacenamientoDeDatos
{

    public partial class frmXml : Form
    {
        public List<Persona> personas = new List<Persona>();

        public frmXml()
        {
            InitializeComponent();

            leerArchivo();
            llenarArchivo();
            dgvPersonas.DataSource = personas;

            dgvPersonas.Columns["id"].HeaderText = "ID";
            dgvPersonas.Columns["name"].HeaderText = "Nombre";
        }

        public void llenarArchivo()
        {
            XElement xElem = new XElement("Personas",
                personas.Select(p => new XElement("Persona",
                    new XElement("ID", p.id),
                    new XElement("Nombre", p.name)
                ))
            );
            xElem.Save("..\\..\\utils\\personas.xml");
        }

        public void leerArchivo()
        {
            if (File.Exists("..\\..\\utils\\personas.xml"))
            {
                XElement xElem = XElement.Load("..\\..\\utils\\personas.xml");
                foreach (var personaElement in xElem.Elements("Persona"))
                {
                    int id = Convert.ToInt32(personaElement.Element("ID").Value);
                    string nombre = personaElement.Element("Nombre").Value;

                    bool idRepetido = false;

                    foreach (Persona p in personas)
                    {
                        if (p.id == id)
                        {
                            idRepetido = true;
                        }
                    }

                    if (idRepetido == false)
                    {
                        personas.Add(new Persona(id, nombre));
                    }
                }
            }
        }

       

        private void imgAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal inicio = new frmPrincipal();
            Hide();
            inicio.Show();
        }

        private void frmXml_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int id = 0;
            bool idRepe = false;

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
                                idRepe = true;
                                break;
                            }
                        }
                    }

                } while (idRepe == true);

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
                    MessageBox.Show("El nombre ha sido modificado correctamente");
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
