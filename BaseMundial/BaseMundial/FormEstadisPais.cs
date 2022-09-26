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
    public partial class FormEstadisPais : Form
    {
        public FormEstadisPais()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarGrid()
        {
            DataTable datos = EstadisticasPaisCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgEstadPais.DataSource = datos.DefaultView;
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodselec.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    EstadisticasPais em = new EstadisticasPais();
                    em.Id_pais = txtcodselec.Text.Trim().ToUpper();
                    em.Gol = Convert.ToInt32(txtgolanota.Text.Trim());
                    em.Tiros_marcos = Convert.ToInt32(txttirosmarco.Text.Trim());
                    em.Tiros_des = Convert.ToInt32(txttirosdes.Text.Trim());
                    em.Tarjetas_amarillas = Convert.ToInt32(txttaramari.Text.Trim());
                    em.Tarjetas_rojas = Convert.ToInt32(txttarroja.Text.Trim());


                    if (EstadisticasPaisCAD.GuardarEstadPais(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Estadisticas de Seleccion Guardadas");
                    }
                    else
                    {
                        MessageBox.Show("No hay Seleccion Registrada con Id");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormEstadisPais_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        bool consultado = false;

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodselec.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                EstadisticasPais em = EstadisticasPaisCAD.consultar(txtcodselec.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el Jugador con Id " + txtcodselec.Text);
                    limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtcodselec.Text = em.Id_pais;
                    txtgolanota.Text = em.Gol.ToString();
                    txttirosmarco.Text = em.Tiros_marcos.ToString();
                    txttirosdes.Text = em.Tiros_des.ToString();
                    txttaramari.Text = em.Tarjetas_amarillas.ToString();
                    txttarroja.Text = em.Tarjetas_rojas.ToString();
                    consultado = true;
                }
            }
        }

        private void limpiarCampos()
        {
            txtcodselec.Text = "";
            txtgolanota.Text = "";
            txttirosmarco.Text = "";
            txttirosdes.Text = "";
            txttaramari.Text = "";
            txttarroja.Text = "";


        }

        private void btbmodificar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar la Seleccion");
            }
            else if (txtcodselec.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una Seleccion Valida");
            }
            else
            {
                try
                {
                    EstadisticasPais em = new EstadisticasPais();
                    em.Id_pais = txtcodselec.Text.Trim();
                    em.Gol = Convert.ToInt32(txtgolanota.Text.Trim());
                    em.Tiros_marcos = Convert.ToInt32(txttirosmarco.Text.Trim());
                    em.Tiros_des = Convert.ToInt32(txttirosdes.Text.Trim());
                    em.Tarjetas_amarillas = Convert.ToInt32(txttaramari.Text.Trim());
                    em.Tarjetas_rojas = Convert.ToInt32(txttarroja.Text.Trim());


                    if (EstadisticasPaisCAD.actualizar(em))
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
            else if (txtcodselec.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {


                    if (EstadisticasPaisCAD.eliminar(txtcodselec.Text.Trim()))
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
