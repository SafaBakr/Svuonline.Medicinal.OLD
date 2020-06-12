using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Svuonline.Medicinal.Desktop.CoVID19
{
    public class ClsUIVaildator
    {
        internal int TxtBoxValidator(String TxtBoxField)
        {
            if (string.IsNullOrWhiteSpace(TxtBoxField))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        internal void InputcharCheck(KeyPressEventArgs e)
        {
            char lastChar = e.KeyChar;
            if (e.KeyChar != 32 && e.KeyChar != 8)
            {
                if (char.IsControl(lastChar) || char.IsDigit(lastChar) || char.IsNumber(lastChar) || char.IsPunctuation(lastChar))
                    e.Handled = true;
                else if (lastChar < 1569)
                    e.Handled = true;
            }
        }
        internal bool EmailValidator(String UserEmail)
        {
            if (string.IsNullOrWhiteSpace(UserEmail))
            {
                return false;
            }
            try
            {
                return UserEmail != null && new EmailAddressAttribute().IsValid(UserEmail);
            }
            catch
            {
                return false;
            }
        }
    }
}
