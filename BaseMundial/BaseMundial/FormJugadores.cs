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
    public partial class FormJugadores : Form
    {
        public FormJugadores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    Jugadores em = new Jugadores();
                    em.Id_jugadores = txtcodjuga.Text;
                    em.Nombre = txtnombre.Text;
                    em.Dorsal = Convert.ToInt32(txtdorsal.Text.Trim());
                    em.Id_pais = txtseleccion.Text;
                    em.Fecha = txtFecha.Value.Year + "-" + txtFecha.Value.Month + "-" + txtFecha.Value.Day;

                    if (JugadoresCAD.GuardarJugadores(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Jugador Guardado");
                    }
                    else
                    {
                        MessageBox.Show("El Id de la Seleccion es Invalido");
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
            DataTable datos = JugadoresCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgJugadores.DataSource = datos.DefaultView;
            }
        }


        private void limpiarCampos()
        {
            txtcodjuga.Text = "";
            txtdorsal.Text = "";
            txtFecha.Text = "";
            txtnombre.Text = "";
            txtseleccion.Text = "";
        }
        private void FormJugadores_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        bool consultado = false;
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                Jugadores em = JugadoresCAD.consultar(txtcodjuga.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el Jugador con Id " + txtcodjuga.Text);
                    limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtcodjuga.Text = em.Id_jugadores;
                    txtnombre.Text = em.Nombre;
                    txtdorsal.Text = em.Dorsal.ToString();
                    txtseleccion.Text = em.Id_pais;
                    txtFecha.Text = em.Fecha;
                    consultado = true;
                }
            }
        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar un Jugador");
            }
            else if (txtcodjuga.Text == "")
            {
                MessageBox.Show("Debe ingresar un Jugador Registrado");
            }
            else
            {
                try
                {
                    Jugadores em = new Jugadores();

                    em.Id_pais = txtseleccion.Text.Trim();
                    em.Fecha = txtFecha.Text.Trim();
                    em.Id_jugadores = txtcodjuga.Text.Trim();
                    em.Nombre = txtnombre.Text.Trim();
                    em.Dorsal = Convert.ToInt32(txtdorsal.Text.Trim());

                    if (JugadoresCAD.actualizar(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Jugador Actualizado");
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
                MessageBox.Show("Debe consultar un Jugador");
            }
            else if (txtseleccion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {


                    if (JugadoresCAD.eliminar(txtseleccion.Text.Trim()))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Jugador Eliminado Correctamente");
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
