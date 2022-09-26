using BaseMundial.Conexion;
using BaseMundial.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BaseMundial
{
    public partial class FormSelecciones : Form
    {
        public FormSelecciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtseleccion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    Seleccion em = new Seleccion();
                    em.Id_pais = txtseleccion.Text.Trim().ToUpper();
                    em.Pais = txtnombre.Text.Trim();
                    em.Entrenador = txtentrenador.Text.Trim();

                    if (SeleccionCAD.GuardarSeleccion(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Seleccion Registrada");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe la Seleccion");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void llenarGrid()
        {
            DataTable datos = SeleccionCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgListSelec.DataSource = datos.DefaultView;
            }
        }


        private void limpiarCampos()
        {
            txtseleccion.Text = "";
            txtentrenador.Text = "";
            txtnombre.Text = "";
        }
        private void FormSelecciones_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        bool consultado = false;

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtseleccion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                Seleccion em = SeleccionCAD.consultar(txtseleccion.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe la Seleccion con Id " + txtseleccion.Text);
                    limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtseleccion.Text = em.Id_pais;
                    txtentrenador.Text = em.Entrenador;
                    txtnombre.Text = em.Pais;
                    consultado = true;
                }
            }
        }

        private void btbmodificar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar la Seleccion");
            }
            else if (txtseleccion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una Seleccion Registrada");
            }
            else
            {
                try
                {
                    Seleccion em = new Seleccion();
                    em.Entrenador = txtentrenador.Text.Trim();
                    em.Id_pais = txtseleccion.Text.Trim();
                    em.Pais = txtnombre.Text.Trim();

                    if (SeleccionCAD.actualizar(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Seleccion Actualizado");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar la Seleccion");
            }
            else if (txtseleccion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {


                    if (SeleccionCAD.eliminar(txtseleccion.Text.Trim()))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Seleccion Eliminada Correctamente");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("No se logro Eliminar");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
