﻿namespace Ejercicios
{
    partial class Ejercicio7
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
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(58, 42);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(163, 368);
            this.ListBox.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(296, 96);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(89, 31);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // Ejercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.ListBox);
            this.Name = "Ejercicio7";
            this.Text = "Ejercicio7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button EjecutarButton;
    }
}