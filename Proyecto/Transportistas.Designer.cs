namespace Proyecto
{
    partial class Transportistas
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
            txtNombreCompañia = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 32);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la Compañia";
            // 
            // txtNombreCompañia
            // 
            txtNombreCompañia.Location = new Point(56, 63);
            txtNombreCompañia.Name = "txtNombreCompañia";
            txtNombreCompañia.Size = new Size(100, 23);
            txtNombreCompañia.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(66, 139);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 108);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Teléfono";
            // 
            // Transportistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 218);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombreCompañia);
            Controls.Add(label1);
            Name = "Transportistas";
            Text = "Transportistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCompañia;
        private TextBox txtTelefono;
        private Label label2;
    }
}