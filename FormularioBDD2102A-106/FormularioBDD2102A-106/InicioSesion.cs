using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace FormularioBDD2102A_106
{
    public partial class InicioSesion : Form
    {
        Formulario102A formulario;
        NpgsqlConnection conn;
        public InicioSesion()
        {
            InitializeComponent();
            formulario = new Formulario102A();
            conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = kjsg19980501; Database = postgres");
        }
        private string sql = null;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioS_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "select * from public.user where name_user = '" + txtusuario.Text + "' and pwd_user = '" + txtPwd.Text + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read()) { 
                    formulario.Show();
                    this.Hide();
                    conn.Close();
                } else {
                    MessageBox.Show("Verifcar usuaio o contraseña");
                    conn.Close();
                }
            } catch (Exception error) { 
                MessageBox.Show("Error" + error);
                conn.Close();
            }
        }
    }
}
