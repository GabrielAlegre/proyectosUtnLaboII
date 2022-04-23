namespace WinFormsApp10MandarInfoDeSecuAprim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnFormaDos = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(106, 49);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(111, 15);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "=============";
            // 
            // btnFormaDos
            // 
            this.btnFormaDos.Location = new System.Drawing.Point(360, 49);
            this.btnFormaDos.Name = "btnFormaDos";
            this.btnFormaDos.Size = new System.Drawing.Size(75, 23);
            this.btnFormaDos.TabIndex = 1;
            this.btnFormaDos.Text = "Agregar forma 2";
            this.btnFormaDos.UseVisualStyleBackColor = true;
            this.btnFormaDos.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(128, 113);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(38, 15);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.btnFormaDos);
            this.Controls.Add(this.lblMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnFormaDos;
        private System.Windows.Forms.Label lblContenido;
    }
}
