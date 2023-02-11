namespace Ejercicios
{
    partial class Ejercicio5
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
            this.HornearButton = new System.Windows.Forms.Button();
            this.Hornear2Button = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.Numero1Label = new System.Windows.Forms.Label();
            this.Numero2Label = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HornearButton
            // 
            this.HornearButton.Location = new System.Drawing.Point(74, 36);
            this.HornearButton.Name = "HornearButton";
            this.HornearButton.Size = new System.Drawing.Size(128, 47);
            this.HornearButton.TabIndex = 0;
            this.HornearButton.Text = "Hornear Pizza";
            this.HornearButton.UseVisualStyleBackColor = true;
            this.HornearButton.Click += new System.EventHandler(this.HornearButton_Click);
            // 
            // Hornear2Button
            // 
            this.Hornear2Button.Location = new System.Drawing.Point(307, 36);
            this.Hornear2Button.Name = "Hornear2Button";
            this.Hornear2Button.Size = new System.Drawing.Size(202, 47);
            this.Hornear2Button.TabIndex = 1;
            this.Hornear2Button.Text = "Honear Pizza Asincrono";
            this.Hornear2Button.UseVisualStyleBackColor = true;
            this.Hornear2Button.Click += new System.EventHandler(this.Hornear2Button_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(380, 207);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(91, 40);
            this.CalcularButton.TabIndex = 2;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Numero1Label
            // 
            this.Numero1Label.AutoSize = true;
            this.Numero1Label.Location = new System.Drawing.Point(91, 185);
            this.Numero1Label.Name = "Numero1Label";
            this.Numero1Label.Size = new System.Drawing.Size(78, 20);
            this.Numero1Label.TabIndex = 3;
            this.Numero1Label.Text = "Numero 1";
            // 
            // Numero2Label
            // 
            this.Numero2Label.AutoSize = true;
            this.Numero2Label.Location = new System.Drawing.Point(91, 247);
            this.Numero2Label.Name = "Numero2Label";
            this.Numero2Label.Size = new System.Drawing.Size(78, 20);
            this.Numero2Label.TabIndex = 4;
            this.Numero2Label.Text = "Numero 2";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(179, 185);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(136, 26);
            this.Numero1TextBox.TabIndex = 5;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(179, 241);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(136, 26);
            this.Numero2TextBox.TabIndex = 6;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 464);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.Numero2Label);
            this.Controls.Add(this.Numero1Label);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.Hornear2Button);
            this.Controls.Add(this.HornearButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HornearButton;
        private System.Windows.Forms.Button Hornear2Button;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label Numero1Label;
        private System.Windows.Forms.Label Numero2Label;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.TextBox Numero2TextBox;
    }
}