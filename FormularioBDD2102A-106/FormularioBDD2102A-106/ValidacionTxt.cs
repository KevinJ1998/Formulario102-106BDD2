using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioBDD2102A_106
{
    class ValidacionTxt
    {
        public void soloLetras(KeyPressEventArgs key)
        {
            try
            {
                if (Char.IsLetter(key.KeyChar))
                {
                    key.Handled = false;
                } else if (Char.IsControl(key.KeyChar))
                {
                    key.Handled = false;
                } else if (Char.IsSeparator(key.KeyChar))
                {
                    key.Handled = false;
                } else
                {
                    key.Handled = true;
                }
            }catch(Exception error)
            {

            }
        }

        public void soloNumeros(KeyPressEventArgs key)
        {
            try
            {
                if (Char.IsNumber(key.KeyChar))
                {
                    key.Handled = false;
                }
                else if (Char.IsControl(key.KeyChar))
                {
                    key.Handled = false;
                }
                else if (Char.IsSeparator(key.KeyChar))
                {
                    key.Handled = false;
                }
                else
                {
                    key.Handled = true;
                }
            }
            catch (Exception error)
            {

            }
        }
    }
}
