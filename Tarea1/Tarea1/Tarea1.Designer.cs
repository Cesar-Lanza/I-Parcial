namespace Tarea1
{
    partial class Tarea1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroLabel.Location = new System.Drawing.Point(49, 77);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(123, 20);
            this.NumeroLabel.TabIndex = 0;
            this.NumeroLabel.Text = "Ingrese Numero";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTextBox.Location = new System.Drawing.Point(178, 74);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(100, 26);
            this.NumeroTextBox.TabIndex = 1;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(110, 124);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(122, 41);
            this.EjecutarButton.TabIndex = 2;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // Tarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.NumeroLabel);
            this.Name = "Tarea1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Button EjecutarButton;
    }
}

