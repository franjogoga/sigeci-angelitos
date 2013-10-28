using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace sigeci_angelitos
{
    public partial class PrincipalForm : Office2007RibbonForm
    {
        TerapeutaForm tf = TerapeutaForm.Instancia();
        public PrincipalForm()
        {
            InitializeComponent();
            
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            tf = TerapeutaForm.Instancia();
            string hola = tf.sacaLabel();
            MessageBox.Show(hola);
            tf.Close();            
        }
   

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            try
            {
                tf = TerapeutaForm.Instancia();
                tf.MdiParent = this;
                tf.Show();
            }
            catch (ObjectDisposedException ex)
            {                
            }
            
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
