namespace Proyecto
{
    partial class Cliente
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 13);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre compañia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 107);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 72);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Ciudad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 122);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Region";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 185);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 6;
            label5.Text = "Codigo postal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 258);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 7;
            label6.Text = "Pais";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 312);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 8;
            label7.Text = "Telefono";
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 330);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 370);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 10;
            label8.Text = "Fax";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(39, 388);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(251, 13);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 12;
            label9.Text = "Nombre del contacto";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(251, 31);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(251, 86);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 14;
            label10.Text = "Dirección";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(251, 104);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cliente";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox6;
    }
}