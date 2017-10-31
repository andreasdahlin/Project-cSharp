using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public static class Validering
    {
        public static bool EmptyTextField(TextBox tb)
        {
            if (tb.Text == string.Empty)
            {
                MessageBox.Show("Fältet är tomt.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool EmptyInterval(TextBox tb)
        {
            int parsedValue;
            if (!int.TryParse(tb.Text, out parsedValue))
            {
                MessageBox.Show("Skriv endast nummer i intervallrutan.");
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool IsUrlCorrect(TextBox tb)
        {
            if (Uri.IsWellFormedUriString(tb.Text, UriKind.Absolute))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Felaktig url.");
                return false;
            }
        }

        public static bool isComboBoxEmpty(ComboBox cb)
        {
            if (string.IsNullOrEmpty(cb.Text))
            {
                MessageBox.Show("Du måste ha valt något i comboboxen.");
                return false;
            }
            return true;
        }
    }
}
