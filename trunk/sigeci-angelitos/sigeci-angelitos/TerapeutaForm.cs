using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevComponents.DotNetBar;

namespace sigeci_angelitos
{
    public partial class TerapeutaForm : Office2007Form
    {
        static TerapeutaForm terapeutaForm = null; //patron singleton
        static public TerapeutaForm Instancia()
        {
            if (terapeutaForm == null)
                terapeutaForm = new TerapeutaForm();
            return terapeutaForm;
        }

        public TerapeutaForm()
        {
            InitializeComponent();
        }

        public string sacaLabel()
        {
            return lblHola.Text;
        }        

    }
}
