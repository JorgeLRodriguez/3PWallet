using BLL;
using BLL.Contracts;
using BLL.Services;
using Domain;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Menu : Form
    {
        private readonly ICuentaService cuentaService;
        private readonly Cuenta Cuenta = default;
        public Menu()
        {
            InitializeComponent();
            cuentaService = CuentaService.Current;
            Cuenta = Session.Instance.CuentaActual;
            LoadSaldo();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void depositobtn_Click(object sender, EventArgs e)
        {
            try
            {
                cuentaService.DepositarPesos(decimal.Parse(cuentapropiamask.Text));
                MessageBox.Show("Deposito correcto.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                cuentapropiamask.Clear();
                LoadSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSaldo()
        {
            saldopesolab.Text = Cuenta.CajaAhorro.Saldo.ToString();
            btcsaldolab.Text = Cuenta.WalletBTC.Saldo.ToString();
        }
        private void pesoaBTCbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cuentaService.ConvertirABTC(decimal.Parse(cuentapropiamask.Text));
                MessageBox.Show("Conversion correcta.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                cuentapropiamask.Clear();
                LoadSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTCapesobtn_Click(object sender, EventArgs e)
        {
            try
            {
                cuentaService.ConvertirAPesos(decimal.Parse(cuentapropiamask.Text));
                MessageBox.Show("Conversion correcta.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                cuentapropiamask.Clear();
                LoadSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void transfBTCbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cuentaService.TransferirBTC(decimal.Parse(saldodestmask.Text), desttxt.Text);
                MessageBox.Show("Transferencia correcta.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                saldodestmask.Clear();
                desttxt.Clear();
                LoadSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void transfpebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cuentaService.TransferirPesos(decimal.Parse(saldodestmask.Text), desttxt.Text);
                MessageBox.Show("Transferencia correcta.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                saldodestmask.Clear();
                desttxt.Clear();
                LoadSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
