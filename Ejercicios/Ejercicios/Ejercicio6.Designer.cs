namespace Ejercicios
{
    partial class Ejercicio6
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(81, 61);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(189, 186);
            this.ListBox.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(325, 106);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(75, 23);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(81, 267);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(131, 21);
            this.ComboBox.TabIndex = 2;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.ListBox);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.ComboBox ComboBox;
    }
}