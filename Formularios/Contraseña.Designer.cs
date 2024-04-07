namespace Crud.Formularios
{
    partial class ContrasenaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContrasenaClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasenaC = new System.Windows.Forms.TextBox();
            this.btncontrasena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola!!!\r\nPara que puedas ingresar a los datos de clientes y provedores necesitas " +
    "tener una contraseña.\r\n\r\nSi no cuentas con ella entonces no podrás entrar.\r\n\r\nSa" +
    "ludos. \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora de ingresar la contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtContrasenaC
            // 
            this.txtContrasenaC.Location = new System.Drawing.Point(292, 285);
            this.txtContrasenaC.Name = "txtContrasenaC";
            this.txtContrasenaC.PasswordChar = '*';
            this.txtContrasenaC.Size = new System.Drawing.Size(205, 20);
            this.txtContrasenaC.TabIndex = 2;
            // 
            // btncontrasena
            // 
            this.btncontrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncontrasena.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontrasena.Location = new System.Drawing.Point(340, 332);
            this.btncontrasena.Name = "btncontrasena";
            this.btncontrasena.Size = new System.Drawing.Size(127, 48);
            this.btncontrasena.TabIndex = 3;
            this.btncontrasena.TabStop = false;
            this.btncontrasena.Text = "Ingresar";
            this.btncontrasena.UseVisualStyleBackColor = false;
            this.btncontrasena.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContrasenaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncontrasena);
            this.Controls.Add(this.txtContrasenaC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContrasenaClientes";
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasenaC;
        private System.Windows.Forms.Button btncontrasena;
    }
}