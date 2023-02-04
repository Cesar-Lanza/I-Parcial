namespace Ejercicios
{
    partial class Ejercicio2
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
            this.components = new System.ComponentModel.Container();
            this.CalcularButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero2TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1TextBox1 = new System.Windows.Forms.TextBox();
            this.OperacionesComboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ResultadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcularButton1
            // 
            this.CalcularButton1.Location = new System.Drawing.Point(300, 276);
            this.CalcularButton1.Name = "CalcularButton1";
            this.CalcularButton1.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton1.TabIndex = 9;
            this.CalcularButton1.Text = "Calcular";
            this.CalcularButton1.UseVisualStyleBackColor = true;
            this.CalcularButton1.Click += new System.EventHandler(this.CalcularButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero 2:";
            // 
            // Numero2TextBox1
            // 
            this.Numero2TextBox1.Location = new System.Drawing.Point(275, 156);
            this.Numero2TextBox1.Name = "Numero2TextBox1";
            this.Numero2TextBox1.Size = new System.Drawing.Size(121, 20);
            this.Numero2TextBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero 1:";
            // 
            // Numero1TextBox1
            // 
            this.Numero1TextBox1.Location = new System.Drawing.Point(275, 91);
            this.Numero1TextBox1.Name = "Numero1TextBox1";
            this.Numero1TextBox1.Size = new System.Drawing.Size(121, 20);
            this.Numero1TextBox1.TabIndex = 5;
            // 
            // OperacionesComboBox1
            // 
            this.OperacionesComboBox1.FormattingEnabled = true;
            this.OperacionesComboBox1.Items.AddRange(new object[] {
            "Suma ",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.OperacionesComboBox1.Location = new System.Drawing.Point(275, 219);
            this.OperacionesComboBox1.Name = "OperacionesComboBox1";
            this.OperacionesComboBox1.Size = new System.Drawing.Size(121, 21);
            this.OperacionesComboBox1.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ResultadoLabel.Location = new System.Drawing.Point(402, 222);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(57, 21);
            this.ResultadoLabel.TabIndex = 11;
            this.ResultadoLabel.Text = "label3";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.OperacionesComboBox1);
            this.Controls.Add(this.CalcularButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero2TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numero1TextBox1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1TextBox1;
        private System.Windows.Forms.ComboBox OperacionesComboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}