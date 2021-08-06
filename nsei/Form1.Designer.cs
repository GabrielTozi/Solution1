
namespace nsei
{
    partial class Somar
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
            this.labeltitulo = new System.Windows.Forms.Label();
            this.labelValor1 = new System.Windows.Forms.Label();
            this.labelValor2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textValor1 = new System.Windows.Forms.TextBox();
            this.textValor2 = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.bntcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltitulo.Location = new System.Drawing.Point(86, 25);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(153, 25);
            this.labeltitulo.TabIndex = 0;
            this.labeltitulo.Text = "Calculo da Soma";
            // 
            // labelValor1
            // 
            this.labelValor1.AutoSize = true;
            this.labelValor1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValor1.Location = new System.Drawing.Point(55, 90);
            this.labelValor1.Name = "labelValor1";
            this.labelValor1.Size = new System.Drawing.Size(52, 19);
            this.labelValor1.TabIndex = 1;
            this.labelValor1.Text = "Valor 1";
            // 
            // labelValor2
            // 
            this.labelValor2.AutoSize = true;
            this.labelValor2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValor2.Location = new System.Drawing.Point(55, 152);
            this.labelValor2.Name = "labelValor2";
            this.labelValor2.Size = new System.Drawing.Size(52, 19);
            this.labelValor2.TabIndex = 2;
            this.labelValor2.Text = "Valor 2";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(55, 215);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(69, 19);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "Resultado";
            // 
            // textValor1
            // 
            this.textValor1.BackColor = System.Drawing.SystemColors.Menu;
            this.textValor1.Location = new System.Drawing.Point(172, 86);
            this.textValor1.Name = "textValor1";
            this.textValor1.Size = new System.Drawing.Size(100, 23);
            this.textValor1.TabIndex = 4;
            // 
            // textValor2
            // 
            this.textValor2.BackColor = System.Drawing.SystemColors.Menu;
            this.textValor2.Location = new System.Drawing.Point(172, 148);
            this.textValor2.Name = "textValor2";
            this.textValor2.Size = new System.Drawing.Size(100, 23);
            this.textValor2.TabIndex = 5;
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.SystemColors.Menu;
            this.textResultado.Location = new System.Drawing.Point(172, 211);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(100, 23);
            this.textResultado.TabIndex = 6;
            // 
            // bntcalcular
            // 
            this.bntcalcular.Location = new System.Drawing.Point(185, 277);
            this.bntcalcular.Name = "bntcalcular";
            this.bntcalcular.Size = new System.Drawing.Size(75, 23);
            this.bntcalcular.TabIndex = 7;
            this.bntcalcular.Text = "Resultado";
            this.bntcalcular.UseVisualStyleBackColor = true;
            this.bntcalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Somar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 363);
            this.Controls.Add(this.bntcalcular);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textValor2);
            this.Controls.Add(this.textValor1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelValor2);
            this.Controls.Add(this.labelValor1);
            this.Controls.Add(this.labeltitulo);
            this.Name = "Somar";
            this.Text = "Calculo da soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label labelValor1;
        private System.Windows.Forms.Label labelValor2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textValor1;
        private System.Windows.Forms.TextBox textValor2;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button bntcalcular;
    }
}

