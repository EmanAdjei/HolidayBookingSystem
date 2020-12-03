using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_B_ClassLibrary.Functionality_B
{
    public class PhoneNumberTextBox : TextBox
    {
        public PhoneNumberTextBox()
        {

        }

        protected override void OnTextChanged(EventArgs e)
        {
            // If characters is longer than 11 turn text red else keep black
            if (Text.Length > 11)
            {
                ForeColor = Color.Red;
            }
            else
            {
                ForeColor = Color.Black;
            }
            // Call Base class OnTextChanged method to handle another other operations
            base.OnTextChanged(e);
        }

        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Only allow numbers as inputs
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Call Base class OnKeyPress method to handle another other operations
            base.OnKeyPress(e);
        }
    }
}
