
namespace UI
{
    partial class crearcuentafr
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
            this.userlab = new System.Windows.Forms.Label();
            this.cuitmask = new System.Windows.Forms.MaskedTextBox();
            this.CBUmask = new System.Windows.Forms.MaskedTextBox();
            this.cuitlab = new System.Windows.Forms.Label();
            this.cbulab = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.crearbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userlab
            // 
            this.userlab.Location = new System.Drawing.Point(12, 9);
            this.userlab.Name = "userlab";
            this.userlab.Size = new System.Drawing.Size(56, 23);
            this.userlab.TabIndex = 0;
            this.userlab.Text = "Usuario:";
            // 
            // cuitmask
            // 
            this.cuitmask.Location = new System.Drawing.Point(74, 39);
            this.cuitmask.Mask = "00000000000";
            this.cuitmask.Name = "cuitmask";
            this.cuitmask.Size = new System.Drawing.Size(100, 23);
            this.cuitmask.TabIndex = 2;
            // 
            // CBUmask
            // 
            this.CBUmask.Location = new System.Drawing.Point(74, 72);
            this.CBUmask.Mask = "99999999";
            this.CBUmask.Name = "CBUmask";
            this.CBUmask.Size = new System.Drawing.Size(100, 23);
            this.CBUmask.TabIndex = 3;
            this.CBUmask.ValidatingType = typeof(int);
            // 
            // cuitlab
            // 
            this.cuitlab.Location = new System.Drawing.Point(12, 41);
            this.cuitlab.Name = "cuitlab";
            this.cuitlab.Size = new System.Drawing.Size(43, 23);
            this.cuitlab.TabIndex = 3;
            this.cuitlab.Text = "CUIT:";
            // 
            // cbulab
            // 
            this.cbulab.Location = new System.Drawing.Point(12, 73);
            this.cbulab.Name = "cbulab";
            this.cbulab.Size = new System.Drawing.Size(43, 23);
            this.cbulab.TabIndex = 4;
            this.cbulab.Text = "CBU";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(74, 6);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(100, 23);
            this.usertxt.TabIndex = 1;
            // 
            // crearbtn
            // 
            this.crearbtn.Location = new System.Drawing.Point(12, 109);
            this.crearbtn.Name = "crearbtn";
            this.crearbtn.Size = new System.Drawing.Size(161, 23);
            this.crearbtn.TabIndex = 4;
            this.crearbtn.Text = "Crear";
            this.crearbtn.UseVisualStyleBackColor = true;
            this.crearbtn.Click += new System.EventHandler(this.crearbtn_Click);
            // 
            // crearcuentafr
            // 
            this.AcceptButton = this.crearbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 144);
            this.Controls.Add(this.crearbtn);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.cbulab);
            this.Controls.Add(this.cuitlab);
            this.Controls.Add(this.CBUmask);
            this.Controls.Add(this.cuitmask);
            this.Controls.Add(this.userlab);
            this.MaximizeBox = false;
            this.Name = "crearcuentafr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearCuenta_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlab;
        private System.Windows.Forms.MaskedTextBox cuitmask;
        private System.Windows.Forms.MaskedTextBox CBUmask;
        private System.Windows.Forms.Label cuitlab;
        private System.Windows.Forms.Label cbulab;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button crearbtn;
    }
}