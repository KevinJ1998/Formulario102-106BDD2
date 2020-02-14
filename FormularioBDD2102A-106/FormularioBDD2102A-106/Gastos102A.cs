using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioBDD2102A_106
{
    public partial class Gastos102A : Form
    {

        Formulario102A f102A;
        ValidacionTxt val = new ValidacionTxt();
        public Gastos102A()
        {
            InitializeComponent();
            f102A = new Formulario102A();
        }
        public static String idcontr;
        public static String valorIngresos;
        public static String valorGastos;

        public void IDContr()
        {
            LblIdContr.Text = Formulario102A.idcontr;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            f102A.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IDContr();
            decimal valorTotal;
            FORM102ATableAdapters.gastosTableAdapter gastos = new FORM102ATableAdapters.gastosTableAdapter();
            valorTotal = decimal.Parse(txtAemp.Text) + decimal.Parse(txtLEProf.Text) + decimal.Parse(txtOLib.Text) + decimal.Parse(txtABInmu.Text) + decimal.Parse(txtGPEdu.Text) + decimal.Parse(txtGPSalud.Text) + decimal.Parse(txtGPAli.Text) + decimal.Parse(txtGPVest.Text) + decimal.Parse(txtGPVivi.Text) + decimal.Parse(txtRPDiscap.Text) + decimal.Parse(txtRPTEdad.Text);
            LblTotGast.Text = valorTotal.ToString();
            try
            {
                gastos.InsertarGastos(Convert.ToInt32(LblIdContr.Text),valorTotal);
                MessageBox.Show("Gastos ingresados!");
            }catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnImpRenta_Click(object sender, EventArgs e)
        {
            Impuestos impuesto = new Impuestos();
            valorGastos = LblTotGast.Text;
            valorIngresos = Formulario102A.valorTotalIng;
            impuesto.Show();
            this.Hide();
        }

        private void txtAemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
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

        private void txtGPEdu_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtGPSalud_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtGPAli_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtGPVivi_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtGPVest_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRPTEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRPDiscap_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }
    }
}
