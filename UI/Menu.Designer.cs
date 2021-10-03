
namespace UI
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pesoslab = new System.Windows.Forms.Label();
            this.saldolab = new System.Windows.Forms.Label();
            this.saldopesolab = new System.Windows.Forms.Label();
            this.btclab = new System.Windows.Forms.Label();
            this.btcsaldolab = new System.Windows.Forms.Label();
            this.cuentapropiamask = new System.Windows.Forms.MaskedTextBox();
            this.depositobtn = new System.Windows.Forms.Button();
            this.pesoaBTCbtn = new System.Windows.Forms.Button();
            this.BTCapesobtn = new System.Windows.Forms.Button();
            this.saldopanel = new System.Windows.Forms.Panel();
            this.propiaaccpanel = new System.Windows.Forms.Panel();
            this.transfpanel = new System.Windows.Forms.Panel();
            this.saldodestmask = new System.Windows.Forms.MaskedTextBox();
            this.transfpebtn = new System.Windows.Forms.Button();
            this.transfBTCbtn = new System.Windows.Forms.Button();
            this.desttxt = new System.Windows.Forms.TextBox();
            this.saldopanel.SuspendLayout();
            this.propiaaccpanel.SuspendLayout();
            this.transfpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pesoslab
            // 
            this.pesoslab.ForeColor = System.Drawing.Color.ForestGreen;
            this.pesoslab.Location = new System.Drawing.Point(64, 34);
            this.pesoslab.Name = "pesoslab";
            this.pesoslab.Size = new System.Drawing.Size(28, 15);
            this.pesoslab.TabIndex = 0;
            this.pesoslab.Text = "$";
            this.pesoslab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saldolab
            // 
            this.saldolab.Location = new System.Drawing.Point(44, 9);
            this.saldolab.Name = "saldolab";
            this.saldolab.Size = new System.Drawing.Size(109, 15);
            this.saldolab.TabIndex = 1;
            this.saldolab.Text = "Saldo";
            this.saldolab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saldopesolab
            // 
            this.saldopesolab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saldopesolab.Location = new System.Drawing.Point(95, 34);
            this.saldopesolab.Name = "saldopesolab";
            this.saldopesolab.Size = new System.Drawing.Size(45, 15);
            this.saldopesolab.TabIndex = 2;
            this.saldopesolab.Text = "0";
            this.saldopesolab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btclab
            // 
            this.btclab.ForeColor = System.Drawing.Color.ForestGreen;
            this.btclab.Location = new System.Drawing.Point(63, 60);
            this.btclab.Name = "btclab";
            this.btclab.Size = new System.Drawing.Size(28, 15);
            this.btclab.TabIndex = 3;
            this.btclab.Text = "BTC";
            this.btclab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btcsaldolab
            // 
            this.btcsaldolab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btcsaldolab.Location = new System.Drawing.Point(95, 60);
            this.btcsaldolab.Name = "btcsaldolab";
            this.btcsaldolab.Size = new System.Drawing.Size(45, 15);
            this.btcsaldolab.TabIndex = 4;
            this.btcsaldolab.Text = "0";
            this.btcsaldolab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cuentapropiamask
            // 
            this.cuentapropiamask.Location = new System.Drawing.Point(53, 13);
            this.cuentapropiamask.Mask = "99999";
            this.cuentapropiamask.Name = "cuentapropiamask";
            this.cuentapropiamask.Size = new System.Drawing.Size(100, 23);
            this.cuentapropiamask.TabIndex = 5;
            this.cuentapropiamask.ValidatingType = typeof(int);
            // 
            // depositobtn
            // 
            this.depositobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositobtn.Location = new System.Drawing.Point(65, 42);
            this.depositobtn.Name = "depositobtn";
            this.depositobtn.Size = new System.Drawing.Size(75, 23);
            this.depositobtn.TabIndex = 6;
            this.depositobtn.Text = "Depositar $";
            this.depositobtn.UseVisualStyleBackColor = true;
            this.depositobtn.Click += new System.EventHandler(this.depositobtn_Click);
            // 
            // pesoaBTCbtn
            // 
            this.pesoaBTCbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesoaBTCbtn.Location = new System.Drawing.Point(65, 69);
            this.pesoaBTCbtn.Name = "pesoaBTCbtn";
            this.pesoaBTCbtn.Size = new System.Drawing.Size(75, 23);
            this.pesoaBTCbtn.TabIndex = 7;
            this.pesoaBTCbtn.Text = "$ a BTC";
            this.pesoaBTCbtn.UseVisualStyleBackColor = true;
            this.pesoaBTCbtn.Click += new System.EventHandler(this.pesoaBTCbtn_Click);
            // 
            // BTCapesobtn
            // 
            this.BTCapesobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCapesobtn.Location = new System.Drawing.Point(65, 98);
            this.BTCapesobtn.Name = "BTCapesobtn";
            this.BTCapesobtn.Size = new System.Drawing.Size(75, 23);
            this.BTCapesobtn.TabIndex = 8;
            this.BTCapesobtn.Text = "BTC a $";
            this.BTCapesobtn.UseVisualStyleBackColor = true;
            this.BTCapesobtn.Click += new System.EventHandler(this.BTCapesobtn_Click);
            // 
            // saldopanel
            // 
            this.saldopanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saldopanel.Controls.Add(this.saldolab);
            this.saldopanel.Controls.Add(this.pesoslab);
            this.saldopanel.Controls.Add(this.saldopesolab);
            this.saldopanel.Controls.Add(this.btclab);
            this.saldopanel.Controls.Add(this.btcsaldolab);
            this.saldopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.saldopanel.Location = new System.Drawing.Point(0, 0);
            this.saldopanel.Name = "saldopanel";
            this.saldopanel.Size = new System.Drawing.Size(212, 100);
            this.saldopanel.TabIndex = 9;
            // 
            // propiaaccpanel
            // 
            this.propiaaccpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.propiaaccpanel.Controls.Add(this.cuentapropiamask);
            this.propiaaccpanel.Controls.Add(this.depositobtn);
            this.propiaaccpanel.Controls.Add(this.BTCapesobtn);
            this.propiaaccpanel.Controls.Add(this.pesoaBTCbtn);
            this.propiaaccpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.propiaaccpanel.Location = new System.Drawing.Point(0, 100);
            this.propiaaccpanel.Name = "propiaaccpanel";
            this.propiaaccpanel.Size = new System.Drawing.Size(212, 133);
            this.propiaaccpanel.TabIndex = 10;
            // 
            // transfpanel
            // 
            this.transfpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transfpanel.Controls.Add(this.saldodestmask);
            this.transfpanel.Controls.Add(this.transfpebtn);
            this.transfpanel.Controls.Add(this.transfBTCbtn);
            this.transfpanel.Controls.Add(this.desttxt);
            this.transfpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.transfpanel.Location = new System.Drawing.Point(0, 233);
            this.transfpanel.Name = "transfpanel";
            this.transfpanel.Size = new System.Drawing.Size(212, 159);
            this.transfpanel.TabIndex = 11;
            // 
            // saldodestmask
            // 
            this.saldodestmask.Location = new System.Drawing.Point(53, 46);
            this.saldodestmask.Mask = "99999";
            this.saldodestmask.Name = "saldodestmask";
            this.saldodestmask.Size = new System.Drawing.Size(100, 23);
            this.saldodestmask.TabIndex = 9;
            this.saldodestmask.ValidatingType = typeof(int);
            // 
            // transfpebtn
            // 
            this.transfpebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfpebtn.Location = new System.Drawing.Point(65, 116);
            this.transfpebtn.Name = "transfpebtn";
            this.transfpebtn.Size = new System.Drawing.Size(75, 23);
            this.transfpebtn.TabIndex = 2;
            this.transfpebtn.Text = "Transf $";
            this.transfpebtn.UseVisualStyleBackColor = true;
            this.transfpebtn.Click += new System.EventHandler(this.transfpebtn_Click);
            // 
            // transfBTCbtn
            // 
            this.transfBTCbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfBTCbtn.Location = new System.Drawing.Point(65, 87);
            this.transfBTCbtn.Name = "transfBTCbtn";
            this.transfBTCbtn.Size = new System.Drawing.Size(75, 23);
            this.transfBTCbtn.TabIndex = 1;
            this.transfBTCbtn.Text = "Transf BTC";
            this.transfBTCbtn.UseVisualStyleBackColor = true;
            this.transfBTCbtn.Click += new System.EventHandler(this.transfBTCbtn_Click);
            // 
            // desttxt
            // 
            this.desttxt.Location = new System.Drawing.Point(53, 17);
            this.desttxt.Name = "desttxt";
            this.desttxt.Size = new System.Drawing.Size(100, 23);
            this.desttxt.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 395);
            this.Controls.Add(this.transfpanel);
            this.Controls.Add(this.propiaaccpanel);
            this.Controls.Add(this.saldopanel);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.saldopanel.ResumeLayout(false);
            this.propiaaccpanel.ResumeLayout(false);
            this.propiaaccpanel.PerformLayout();
            this.transfpanel.ResumeLayout(false);
            this.transfpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pesoslab;
        private System.Windows.Forms.Label saldolab;
        private System.Windows.Forms.Label saldopesolab;
        private System.Windows.Forms.Label btclab;
        private System.Windows.Forms.Label btcsaldolab;
        private System.Windows.Forms.MaskedTextBox cuentapropiamask;
        private System.Windows.Forms.Button depositobtn;
        private System.Windows.Forms.Button pesoaBTCbtn;
        private System.Windows.Forms.Button BTCapesobtn;
        private System.Windows.Forms.Panel saldopanel;
        private System.Windows.Forms.Panel propiaaccpanel;
        private System.Windows.Forms.Panel transfpanel;
        private System.Windows.Forms.MaskedTextBox saldodestmask;
        private System.Windows.Forms.Button transfpebtn;
        private System.Windows.Forms.Button transfBTCbtn;
        private System.Windows.Forms.TextBox desttxt;
    }
}