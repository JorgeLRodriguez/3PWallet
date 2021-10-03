using BLL.Contracts;
using BLL.Services;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ingresarfr : Form
    {
        private readonly ICuentaService cuentaService;
        public ingresarfr()
        {
            InitializeComponent();
            cuentaService = CuentaService.Current;
        }

        private void crearCuentabtn_Click(object sender, EventArgs e)
        {
            Hide();
            using (crearcuentafr crearcuentafr = new crearcuentafr())
                crearcuentafr.ShowDialog();
            Show();
        }
        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ingresarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cuentaService.Ingresar(usuariotxt.Text).Equals(null)) return;
                new Menu().Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
