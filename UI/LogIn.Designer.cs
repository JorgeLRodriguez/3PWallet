
namespace UI
{
    partial class ingresarfr
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
            this.crearCuentabtn = new System.Windows.Forms.Button();
            this.ingresarbtn = new System.Windows.Forms.Button();
            this.usuariolab = new System.Windows.Forms.Label();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crearCuentabtn
            // 
            this.crearCuentabtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crearCuentabtn.Location = new System.Drawing.Point(88, 85);
            this.crearCuentabtn.Name = "crearCuentabtn";
            this.crearCuentabtn.Size = new System.Drawing.Size(100, 23);
            this.crearCuentabtn.TabIndex = 3;
            this.crearCuentabtn.Text = "Crear Cuenta";
            this.crearCuentabtn.UseVisualStyleBackColor = true;
            this.crearCuentabtn.Click += new System.EventHandler(this.crearCuentabtn_Click);
            // 
            // ingresarbtn
            // 
            this.ingresarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarbtn.Location = new System.Drawing.Point(88, 56);
            this.ingresarbtn.Name = "ingresarbtn";
            this.ingresarbtn.Size = new System.Drawing.Size(100, 23);
            this.ingresarbtn.TabIndex = 2;
            this.ingresarbtn.Text = "Ingresar";
            this.ingresarbtn.UseVisualStyleBackColor = true;
            this.ingresarbtn.Click += new System.EventHandler(this.ingresarbtn_Click);
            // 
            // usuariolab
            // 
            this.usuariolab.Location = new System.Drawing.Point(88, 9);
            this.usuariolab.Name = "usuariolab";
            this.usuariolab.Size = new System.Drawing.Size(100, 15);
            this.usuariolab.TabIndex = 2;
            this.usuariolab.Text = "Usuario:";
            this.usuariolab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuariotxt
            // 
            this.usuariotxt.Location = new System.Drawing.Point(88, 27);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(100, 23);
            this.usuariotxt.TabIndex = 1;
            // 
            // ingresarfr
            // 
            this.AcceptButton = this.ingresarbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 117);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.usuariolab);
            this.Controls.Add(this.ingresarbtn);
            this.Controls.Add(this.crearCuentabtn);
            this.MaximizeBox = false;
            this.Name = "ingresarfr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crearCuentabtn;
        private System.Windows.Forms.Button ingresarbtn;
        private System.Windows.Forms.Label usuariolab;
        private System.Windows.Forms.TextBox usuariotxt;
    }
}