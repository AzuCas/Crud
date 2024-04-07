namespace Crud.Formularios
{
    partial class TallasHom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TallasHom));
            this.label2 = new System.Windows.Forms.Label();
            this.cBProductos = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Estilo";
            // 
            // cBProductos
            // 
            this.cBProductos.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBProductos.FormattingEnabled = true;
            this.cBProductos.Items.AddRange(new object[] {
            "Zapatillas",
            "Botas",
            "Tacones",
            "Huaraches",
            "Tennis",
            "Casuales",
            "Botas altas",
            "Mocasin",
            "De vestir",
            "Deportivo"});
            this.cBProductos.Location = new System.Drawing.Point(279, 111);
            this.cBProductos.Name = "cBProductos";
            this.cBProductos.Size = new System.Drawing.Size(140, 214);
            this.cBProductos.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tallas";
            // 
            // Productos
            // 
            this.Productos.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.FormattingEnabled = true;
            this.Productos.Items.AddRange(new object[] {
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.Productos.Location = new System.Drawing.Point(41, 93);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(128, 277);
            this.Productos.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crud.Properties.Resources.lo_quiero;
            this.pictureBox1.Location = new System.Drawing.Point(470, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // TallasHom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Productos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TallasHom";
            this.Text = "TallasHom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cBProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Productos;
    }
}