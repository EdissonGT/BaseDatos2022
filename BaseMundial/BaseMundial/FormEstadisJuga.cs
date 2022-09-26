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

namespace BaseMundial
{
    public partial class FormEstadisJuga : Form
    {
        public FormEstadisJuga()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarGrid()
        {
            DataTable datos = EstadJugCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgEstadJug.DataSource = datos.DefaultView;
            }
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
                    EstadJug em = new EstadJug();
                    em.Id_jugador = txtcodjuga.Text.Trim().ToUpper();
                    em.Goles = Convert.ToInt32(txtgolAnota.Text.Trim());
                    em.Tiros_marc = Convert.ToInt32(txttirosmarco.Text.Trim());
                    em.Tiros_des = Convert.ToInt32(txttirosdes.Text.Trim());
                    em.Tarjetas_amarillas = Convert.ToInt32(txttarama.Text.Trim());
                    em.Tarjetas_rojas = Convert.ToInt32(txttarroja.Text.Trim());
                    em.Minutos = Convert.ToInt32(txtminjug.Text.Trim());
                    em.Asistencias = Convert.ToInt32(txtasistencias.Text.Trim());

                    if (EstadJugCAD.GuardarEstadJugador(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Estadisticas de Jugador Guardadas");
                    }
                    else
                    {
                        MessageBox.Show("No hay jugador Registrado con Id");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormEstadisJuga_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        bool consultado = false;

        private void limpiarCampos()
        {
            txtcodjuga.Text = "";
            txtgolAnota.Text = "";
            txttirosmarco.Text = "";
            txttirosdes.Text = "";
            txttarama.Text = "";
            txttarroja.Text = "";
            txtminjug.Text = "";
            txtasistencias.Text = "";

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                EstadJug em = EstadJugCAD.consultar(txtcodjuga.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el Jugador con Id " + txtcodjuga.Text);
                    limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtcodjuga.Text = em.Id_jugador;
                    txtgolAnota.Text = em.Goles.ToString();
                    txttirosmarco.Text = em.Tiros_marc.ToString();
                    txttirosdes.Text = em.Tiros_des.ToString();
                    txttarama.Text = em.Tarjetas_amarillas.ToString();
                    txttarroja.Text = em.Tarjetas_rojas.ToString();
                    txtminjug.Text = em.Minutos.ToString();
                    txtasistencias.Text = em.Asistencias.ToString();
                    consultado = true;
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el COD del Jugador");
            }
            else if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {


                    if (EstadJugCAD.eliminar(txtcodjuga.Text.Trim()))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Estadisticas Eliminadas Correctamente");
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

        private void btbmodificar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el COD Jugador");
            }
            else if (txtcodjuga.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Jugador Registrado");
            }
            else
            {
                try
                {
                    EstadJug em = new EstadJug();
                    em.Id_jugador = txtcodjuga.Text.Trim();
                    em.Goles = Convert.ToInt32(txtgolAnota.Text.Trim());
                    em.Tiros_marc = Convert.ToInt32(txttirosmarco.Text.Trim());
                    em.Tiros_des = Convert.ToInt32(txttirosdes.Text.Trim());
                    em.Tarjetas_amarillas = Convert.ToInt32(txttarama.Text.Trim());
                    em.Tarjetas_rojas = Convert.ToInt32(txttarroja.Text.Trim());
                    em.Minutos = Convert.ToInt32(txtminjug.Text.Trim());
                    em.Asistencias = Convert.ToInt32(txtasistencias.Text.Trim());

                    if (EstadJugCAD.actualizar(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Estadisticas del Jugador Actualizadas");
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
    }
}
