namespace WinFormsApp8enviarInfoModal
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnvioUno = new System.Windows.Forms.Button();
            this.btnEnvioDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(136, 69);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(100, 23);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnEnvioUno
            // 
            this.btnEnvioUno.Location = new System.Drawing.Point(354, 69);
            this.btnEnvioUno.Name = "btnEnvioUno";
            this.btnEnvioUno.Size = new System.Drawing.Size(75, 23);
            this.btnEnvioUno.TabIndex = 1;
            this.btnEnvioUno.Text = "Envio 1";
            this.btnEnvioUno.UseVisualStyleBackColor = true;
            this.btnEnvioUno.Click += new System.EventHandler(this.btnEnvioUno_Click);
            // 
            // btnEnvioDos
            // 
            this.btnEnvioDos.Location = new System.Drawing.Point(354, 121);
            this.btnEnvioDos.Name = "btnEnvioDos";
            this.btnEnvioDos.Size = new System.Drawing.Size(75, 23);
            this.btnEnvioDos.TabIndex = 2;
            this.btnEnvioDos.Text = "Envio 2";
            this.btnEnvioDos.UseVisualStyleBackColor = true;
            this.btnEnvioDos.Click += new System.EventHandler(this.btnEnvioDos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 181);
            this.Controls.Add(this.btnEnvioDos);
            this.Controls.Add(this.btnEnvioUno);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnvioUno;
        private System.Windows.Forms.Button btnEnvioDos;
    }
}
