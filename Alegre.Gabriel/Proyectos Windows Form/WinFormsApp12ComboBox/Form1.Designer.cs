namespace WinFormsApp12ComboBox
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
            this.cmbAlimentos = new System.Windows.Forms.ComboBox();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAlimentos
            // 
            this.cmbAlimentos.FormattingEnabled = true;
            this.cmbAlimentos.Items.AddRange(new object[] {
            "Frijol",
            "Tomate"});
            this.cmbAlimentos.Location = new System.Drawing.Point(91, 32);
            this.cmbAlimentos.Name = "cmbAlimentos";
            this.cmbAlimentos.Size = new System.Drawing.Size(121, 23);
            this.cmbAlimentos.TabIndex = 0;
            this.cmbAlimentos.Text = "Alimentos";
            this.cmbAlimentos.SelectedIndexChanged += new System.EventHandler(this.cmbAlimentos_SelectedIndexChanged);
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(91, 135);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(100, 23);
            this.txtAlimento.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(297, 135);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(91, 97);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(38, 15);
            this.lblIndice.TabIndex = 3;
            this.lblIndice.Text = "label1";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(311, 97);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(38, 15);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 265);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.cmbAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlimentos;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblTexto;
    }
}
