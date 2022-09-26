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
    public partial class FormDetallesGol : Form
    {
        public FormDetallesGol()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodgol.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {
                    Gol em = new Gol();
                    em.Id_detalle = txtcodgol.Text;
                    em.Seleccion = txtselecc.Text;
                    em.Jug_gol = txtjugagol.Text;
                    em.Jug_asis = txtjugaasisten.Text;
                    em.Tipo_gol = txttipogol.Text;

                    if (GolCAD.GuardarGol(em))
                    {
                        //llenarGrid();
                        //limpiarCampos();
                        MessageBox.Show("Gol Guardado");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el Gol");
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
            DataTable datos = GolCAD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dgGol.DataSource = datos.DefaultView;
            }
        }
        private void FormDetallesGol_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }


        bool consultado = false;
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodgol.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id");
            }
            else
            {
                Gol em = GolCAD.consultar(txtcodgol.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("No existe el Jugador con Id " + txtcodgol.Text);
                    limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtcodgol.Text = em.Id_detalle;
                    txtselecc.Text = em.Seleccion;
                    txtjugagol.Text = em.Jug_gol;
                    txtjugaasisten.Text = em.Jug_asis;
                    txttipogol.Text = em.Tipo_gol;
                    consultado = true;
                }
            }
        }

       

        private void limpiarCampos()
        {
            txtcodgol.Text = "";
            txtselecc.Text = "";
            txtjugagol.Text = "";
            txtjugaasisten.Text = "";
            txtjugagol.Text = "";
            txttipogol.Text = "";
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar la Seleccion");
            }
            else if (txtcodgol.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Id valido");
            }
            else
            {
                try
                {


                    if (GolCAD.eliminar(txtcodgol.Text.Trim()))
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

        private void btbmodificar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el Jugador");
            }
            else if (txtcodgol.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Jugador Valido");
            }
            else
            {
                try
                {
                    Gol em = new Gol();
                    em.Id_detalle = txtcodgol.Text.Trim();
                    em.Seleccion = txtselecc.Text.Trim();
                    em.Jug_gol = txtjugagol.Text.Trim();
                    em.Jug_asis = txtjugaasisten.Text.Trim();
                    em.Tipo_gol = txttipogol.Text.Trim();

                    if (GolCAD.actualizar(em))
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




    }
}
