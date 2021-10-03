using BLL.Contracts;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class crearcuentafr : Form
    {
        private readonly ICuentaService cuentaService;
        public crearcuentafr()
        {
            InitializeComponent();
            cuentaService = CuentaService.Current;
        }

        private void CrearCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void crearbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cuentaService.Create(usertxt.Text, int.Parse(cuitmask.Text.Trim('-')), long.Parse(CBUmask.Text));
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
