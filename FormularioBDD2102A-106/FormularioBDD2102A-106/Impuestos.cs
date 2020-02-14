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
    public partial class Impuestos : Form
    {
        public Impuestos()
        {
            InitializeComponent();

            CargarDatos();
        }
        public static decimal impuesto;
        public void CargarID()
        {
            LblIdContr.Text = Formulario102A.idcontr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM102ATableAdapters.contribuyenteTableAdapter contribuyente = new FORM102ATableAdapters.contribuyenteTableAdapter();
            contribuyente.ActualizarSaldoContr(impuesto, Convert.ToInt32(LblIdContr.Text));
            Formulario106 formulario106 = new Formulario106();
            formulario106.Show();
            this.Hide();
        }
        public void CargarDatos()
        {
            CargarID();
            FORM102ATableAdapters.ingresosTableAdapter ingresos = new FORM102ATableAdapters.ingresosTableAdapter();
            FORM102A.ingresosDataTable table = ingresos.GetIngresosContr(Convert.ToInt32(LblIdContr.Text));
            FORM102A.ingresosRow ingresosRow = (FORM102A.ingresosRow)table.Rows[0];
            FORM102ATableAdapters.gastosTableAdapter gastos = new FORM102ATableAdapters.gastosTableAdapter();
            FORM102A.gastosDataTable table2 = gastos.GetGastosContr(Convert.ToInt32(LblIdContr.Text));
            FORM102A.gastosRow gastosRow = (FORM102A.gastosRow)table2.Rows[0];
            LblGastos.Text = gastosRow.valor_gast.ToString();
            LblIngresos.Text = ingresosRow.valor_ingre.ToString();

            impuesto = decimal.Parse(LblIngresos.Text) - decimal.Parse(LblGastos.Text);
            LblImpRenta.Text = impuesto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
