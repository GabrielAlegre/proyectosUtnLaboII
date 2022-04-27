
namespace polimorfismoWinFormLaCentralitaEP2
{
    partial class FrmLlamador
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.gbxPanel = new System.Windows.Forms.GroupBox();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnSharp = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.gbxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(26, 35);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 39);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(88, 35);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 39);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(150, 35);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 39);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // gbxPanel
            // 
            this.gbxPanel.Controls.Add(this.btnAsterisco);
            this.gbxPanel.Controls.Add(this.btnCero);
            this.gbxPanel.Controls.Add(this.btnSharp);
            this.gbxPanel.Controls.Add(this.btn7);
            this.gbxPanel.Controls.Add(this.btn8);
            this.gbxPanel.Controls.Add(this.btn9);
            this.gbxPanel.Controls.Add(this.btn4);
            this.gbxPanel.Controls.Add(this.btn5);
            this.gbxPanel.Controls.Add(this.btn6);
            this.gbxPanel.Controls.Add(this.btn1);
            this.gbxPanel.Controls.Add(this.btn2);
            this.gbxPanel.Controls.Add(this.btn3);
            this.gbxPanel.Location = new System.Drawing.Point(14, 57);
            this.gbxPanel.Name = "gbxPanel";
            this.gbxPanel.Size = new System.Drawing.Size(221, 230);
            this.gbxPanel.TabIndex = 12;
            this.gbxPanel.TabStop = false;
            this.gbxPanel.Text = "Panel";
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(26, 175);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(45, 39);
            this.btnAsterisco.TabIndex = 9;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(88, 175);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(45, 39);
            this.btnCero.TabIndex = 10;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btnSharp
            // 
            this.btnSharp.Location = new System.Drawing.Point(152, 175);
            this.btnSharp.Name = "btnSharp";
            this.btnSharp.Size = new System.Drawing.Size(45, 39);
            this.btnSharp.TabIndex = 11;
            this.btnSharp.Text = "#";
            this.btnSharp.UseVisualStyleBackColor = true;
            this.btnSharp.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(26, 130);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 39);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(88, 130);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 39);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(152, 130);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 39);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(26, 85);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 39);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(88, 85);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 39);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(152, 85);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 39);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.escribirNumeroTelefonivo);
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNroDestino.Location = new System.Drawing.Point(14, 12);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(411, 35);
            this.txtNroDestino.TabIndex = 13;
            this.txtNroDestino.Text = "Nro Destino";
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(255, 92);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(170, 30);
            this.btnLlamar.TabIndex = 14;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(255, 142);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(170, 30);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 30);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNroOrigen.Location = new System.Drawing.Point(255, 187);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(170, 25);
            this.txtNroOrigen.TabIndex = 17;
            this.txtNroOrigen.Text = "Nro Origen";
            // 
            // cmbFranja
            // 
            this.cmbFranja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(14, 299);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(411, 29);
            this.cmbFranja.TabIndex = 18;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 343);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtNroDestino);
            this.Controls.Add(this.gbxPanel);
            this.Name = "FrmLlamador";
            this.Text = "FrmLlamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.gbxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.GroupBox gbxPanel;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnSharp;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.ComboBox cmbFranja;
    }
}