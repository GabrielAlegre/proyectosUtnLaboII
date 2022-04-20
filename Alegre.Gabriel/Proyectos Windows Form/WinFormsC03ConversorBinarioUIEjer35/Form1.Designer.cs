
namespace WinFormsC03ConversorBinarioUIEjer35
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
            this.txtValorBinario = new System.Windows.Forms.TextBox();
            this.txtDecimalAbinario = new System.Windows.Forms.TextBox();
            this.txtBinarioADecimal = new System.Windows.Forms.TextBox();
            this.txtValorDecimal = new System.Windows.Forms.TextBox();
            this.btnConvertBinarioDecimal = new System.Windows.Forms.Button();
            this.btnConvertDecimalBinario = new System.Windows.Forms.Button();
            this.lblNumeroBinarioDecimal = new System.Windows.Forms.Label();
            this.lblNumeroDecimalBinario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorBinario
            // 
            this.txtValorBinario.Location = new System.Drawing.Point(162, 56);
            this.txtValorBinario.Name = "txtValorBinario";
            this.txtValorBinario.Size = new System.Drawing.Size(100, 23);
            this.txtValorBinario.TabIndex = 0;
            // 
            // txtDecimalAbinario
            // 
            this.txtDecimalAbinario.Location = new System.Drawing.Point(429, 109);
            this.txtDecimalAbinario.Name = "txtDecimalAbinario";
            this.txtDecimalAbinario.Size = new System.Drawing.Size(100, 23);
            this.txtDecimalAbinario.TabIndex = 2;
            // 
            // txtBinarioADecimal
            // 
            this.txtBinarioADecimal.Location = new System.Drawing.Point(429, 56);
            this.txtBinarioADecimal.Name = "txtBinarioADecimal";
            this.txtBinarioADecimal.Size = new System.Drawing.Size(100, 23);
            this.txtBinarioADecimal.TabIndex = 4;
            // 
            // txtValorDecimal
            // 
            this.txtValorDecimal.Location = new System.Drawing.Point(162, 109);
            this.txtValorDecimal.Name = "txtValorDecimal";
            this.txtValorDecimal.Size = new System.Drawing.Size(100, 23);
            this.txtValorDecimal.TabIndex = 6;
            // 
            // btnConvertBinarioDecimal
            // 
            this.btnConvertBinarioDecimal.Location = new System.Drawing.Point(310, 56);
            this.btnConvertBinarioDecimal.Name = "btnConvertBinarioDecimal";
            this.btnConvertBinarioDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnConvertBinarioDecimal.TabIndex = 7;
            this.btnConvertBinarioDecimal.Text = "->";
            this.btnConvertBinarioDecimal.UseVisualStyleBackColor = true;
            this.btnConvertBinarioDecimal.Click += new System.EventHandler(this.btnConvertBinarioDecimal_Click);
            // 
            // btnConvertDecimalBinario
            // 
            this.btnConvertDecimalBinario.Location = new System.Drawing.Point(310, 109);
            this.btnConvertDecimalBinario.Name = "btnConvertDecimalBinario";
            this.btnConvertDecimalBinario.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDecimalBinario.TabIndex = 9;
            this.btnConvertDecimalBinario.Text = "->";
            this.btnConvertDecimalBinario.UseVisualStyleBackColor = true;
            this.btnConvertDecimalBinario.Click += new System.EventHandler(this.btnConvertDecimalBinario_Click);
            // 
            // lblNumeroBinarioDecimal
            // 
            this.lblNumeroBinarioDecimal.AutoSize = true;
            this.lblNumeroBinarioDecimal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroBinarioDecimal.Location = new System.Drawing.Point(29, 56);
            this.lblNumeroBinarioDecimal.Name = "lblNumeroBinarioDecimal";
            this.lblNumeroBinarioDecimal.Size = new System.Drawing.Size(125, 20);
            this.lblNumeroBinarioDecimal.TabIndex = 10;
            this.lblNumeroBinarioDecimal.Text = "Binario a decimal";
            // 
            // lblNumeroDecimalBinario
            // 
            this.lblNumeroDecimalBinario.AutoSize = true;
            this.lblNumeroDecimalBinario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroDecimalBinario.Location = new System.Drawing.Point(29, 109);
            this.lblNumeroDecimalBinario.Name = "lblNumeroDecimalBinario";
            this.lblNumeroDecimalBinario.Size = new System.Drawing.Size(127, 20);
            this.lblNumeroDecimalBinario.TabIndex = 12;
            this.lblNumeroDecimalBinario.Text = "Decimal a binario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 188);
            this.Controls.Add(this.lblNumeroDecimalBinario);
            this.Controls.Add(this.lblNumeroBinarioDecimal);
            this.Controls.Add(this.btnConvertDecimalBinario);
            this.Controls.Add(this.btnConvertBinarioDecimal);
            this.Controls.Add(this.txtValorDecimal);
            this.Controls.Add(this.txtBinarioADecimal);
            this.Controls.Add(this.txtDecimalAbinario);
            this.Controls.Add(this.txtValorBinario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorBinario;
        private System.Windows.Forms.TextBox txtDecimalAbinario;
        private System.Windows.Forms.TextBox txtBinarioADecimal;
        private System.Windows.Forms.TextBox txtValorDecimal;
        private System.Windows.Forms.Button btnConvertBinarioDecimal;
        private System.Windows.Forms.Button btnConvertDecimalBinario;
        private System.Windows.Forms.Label lblNumeroBinarioDecimal;
        private System.Windows.Forms.Label lblNumeroDecimalBinario;
    }
}

