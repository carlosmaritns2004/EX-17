﻿namespace EX_17
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            ListaUtilizadores = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(578, 281);
            button1.Name = "button1";
            button1.Size = new Size(104, 38);
            button1.TabIndex = 0;
            button1.Text = "Pagina 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(527, 208);
            button2.Name = "button2";
            button2.Size = new Size(155, 52);
            button2.TabIndex = 1;
            button2.Text = "Mostrar Utilizadores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ListaUtilizadores
            // 
            ListaUtilizadores.FormattingEnabled = true;
            ListaUtilizadores.ItemHeight = 15;
            ListaUtilizadores.Location = new Point(66, 197);
            ListaUtilizadores.Name = "ListaUtilizadores";
            ListaUtilizadores.Size = new Size(120, 94);
            ListaUtilizadores.TabIndex = 2;
            ListaUtilizadores.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaUtilizadores);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox ListaUtilizadores;
    }
}