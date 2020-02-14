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
    public partial class Formulario106 : Form
    {
        ValidacionTxt val = new ValidacionTxt();
        public Formulario106()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            decimal total_pagado;
            FORM102ATableAdapters.F106TableAdapter f106Table = new FORM102ATableAdapters.F106TableAdapter();
            total_pagado = decimal.Parse(txtImp.Text) + decimal.Parse(txtIntRecarg.Text) + decimal.Parse(txtMultRecarg.Text);
            txtTotPag.Text = total_pagado.ToString();
            try
            {
                f106Table.InsertarPago(txtCodDoc.Text, txtCiudad.Text, txtAnio.Text, txtMes.Text, txtDesc.Text, total_pagado, Convert.ToInt32(LblIdContr.Text));
                MessageBox.Show("Pago guardado");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public void CargarIDContr()
        {
            LblIdContr.Text = Formulario102A.idcontr;
        }

        public void cargarDatos()
        {
            CargarIDContr();
            FORM102ATableAdapters.contribuyenteTableAdapter contribuyente = new FORM102ATableAdapters.contribuyenteTableAdapter();
            FORM102A.contribuyenteDataTable table = contribuyente.GetDatosContr(Convert.ToInt32(LblIdContr.Text));
            FORM102A.contribuyenteRow contribuyenteRow = (FORM102A.contribuyenteRow)table.Rows[0];
            txtRazonS.Text = contribuyenteRow.razonSocial_contr.ToString();
            txtRUC.Text = contribuyenteRow.ruc_contr.ToString();
            txtImp.Text = contribuyenteRow.saldo_contr.ToString();
            txtCodImp.Text = "FA3H45";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void txtIntRecarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtMultRecarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
