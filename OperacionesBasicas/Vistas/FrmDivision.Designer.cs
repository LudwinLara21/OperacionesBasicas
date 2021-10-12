
namespace OperacionesBasicas.Vistas
{
    partial class FrmDivision
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
            this.label4 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textDato2 = new System.Windows.Forms.TextBox();
            this.textDato1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Resultado";
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(391, 185);
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(73, 22);
            this.textResultado.TabIndex = 44;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 43;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textDato2
            // 
            this.textDato2.Location = new System.Drawing.Point(298, 194);
            this.textDato2.Name = "textDato2";
            this.textDato2.Size = new System.Drawing.Size(52, 22);
            this.textDato2.TabIndex = 42;
            this.textDato2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDato1
            // 
            this.textDato1.Location = new System.Drawing.Point(298, 164);
            this.textDato1.Name = "textDato1";
            this.textDato1.Size = new System.Drawing.Size(52, 22);
            this.textDato1.TabIndex = 41;
            this.textDato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Division";
            // 
            // FrmDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDato2);
            this.Controls.Add(this.textDato1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDivision";
            this.Text = "FrmDivision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textDato2;
        private System.Windows.Forms.TextBox textDato1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}