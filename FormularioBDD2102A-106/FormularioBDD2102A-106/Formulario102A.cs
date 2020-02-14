using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioBDD2102A_106
{
    public partial class Formulario102A : Form
    {
        Gastos102A g10A;
        ValidacionTxt val = new ValidacionTxt();
        public Formulario102A()
        {
            InitializeComponent();
        }
        public static String idcontr;
        public static String valorTotalIng;
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            idcontr = LblIngresos.Text;
            valorTotalIng = LblIngTot.Text;
            g10A = new Gastos102A();
            this.Hide();
            g10A.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IdContribuyente();
            decimal valorTotal;
            FORM102ATableAdapters.ingresosTableAdapter ingresos = new FORM102ATableAdapters.ingresosTableAdapter();
            valorTotal = decimal.Parse(txtAEmp.Text)+decimal.Parse(txtLEProf.Text)+decimal.Parse(txtOLib.Text)+decimal.Parse(txtABInmu.Text)+decimal.Parse(txtIPExt.Text)+decimal.Parse(txtIPRega.Text)+decimal.Parse(txtIPLot.Text)+decimal.Parse(txtHLD.Text)+decimal.Parse(txtDPSoci.Text)+decimal.Parse(txtPJubi.Text)+decimal.Parse(txtOIExe.Text);
            LblIngTot.Text = valorTotal.ToString();
            try
            {
                ingresos.InsertarIngresos(Convert.ToInt32(LblIngresos.Text),valorTotal);
                MessageBox.Show("Ingresos insertados!!");
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void InsertarContribuyente()
        {
            FORM102ATableAdapters.contribuyenteTableAdapter ingresos = new FORM102ATableAdapters.contribuyenteTableAdapter();
            try
            {
                if (ExistContr())
                {
                    MessageBox.Show("El contribuyente ya existe");
                } else 
                { 
                    ingresos.InserContribuyente(txtRUC.Text.Trim(), txtRSocial.Text.Trim());
                    MessageBox.Show("Contribuyente guardado");
                }
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void IdContribuyente()
        {
            SqlConnection conn =  new SqlConnection(@"Data Source = DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog = FORM102A;Integrated Security = True");
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String query = "SELECT id_contr FROM contribuyente WHERE ruc_contr like @ruc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ruc",txtRUC.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LblIngresos.Text = reader["id_contr"].ToString();
                }
            }catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conn.Close();
        }
        public bool ExistContr()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog = FORM102A;Integrated Security = True");
            bool exist = false;
            try
            {
                conn.Open();
                String query = "SELECT ruc_contr FROM contribuyente WHERE ruc_contr like @ruc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ruc", txtRUC.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if(txtRUC.Text.Equals(reader["ruc_contr"].ToString()))
                    {
                        exist = true;
                    } else
                    {
                        exist = false;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            conn.Close();
            return exist;
        }

        private void BtnGuarContr_Click(object sender, EventArgs e)
        {
            InsertarContribuyente();
        }

        private void txtAEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void txtLEProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtOLib_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtABInmu_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtIPExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtIPRega_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtIPLot_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtHLD_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtDPSoci_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtPJubi_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtOIExe_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtPJubi_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }
    }
}
