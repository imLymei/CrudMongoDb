﻿namespace Crud
{
    partial class frmDetalhe
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
            components = new System.ComponentModel.Container();
            bsDetalhe = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).BeginInit();
            SuspendLayout();
            // 
            // bsDetalhe
            // 
            bsDetalhe.DataSource = typeof(DAL.Agenda);
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MintCream;
            textBox1.DataBindings.Add(new Binding("Text", bsDetalhe, "Nome", true));
            textBox1.Location = new Point(12, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Endereco";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MintCream;
            textBox2.DataBindings.Add(new Binding("Text", bsDetalhe, "Endereco", true));
            textBox2.Location = new Point(12, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MintCream;
            textBox3.DataBindings.Add(new Binding("Text", bsDetalhe, "Telefone", true));
            textBox3.Location = new Point(12, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(271, 150);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(65, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(196, 150);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 30);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // frmDetalhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 250, 214);
            ClientSize = new Size(348, 198);
            Controls.Add(btnOk);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDetalhe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhe";
            Load += frmDetalhe_Load;
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsDetalhe;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button btnCancelar;
        private Button btnOk;
    }
}