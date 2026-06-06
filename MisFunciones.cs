using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus
{
    internal class MisFunciones
    {
        public static void MensajeAlerta(string mensaje)
        {
            MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
