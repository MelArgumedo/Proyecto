namespace Proyecto
{
    partial class Territorios
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
            txtDescripcionTerritorio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción del territorio";
            // 
            // txtDescripcionTerritorio
            // 
            txtDescripcionTerritorio.Location = new Point(39, 61);
            txtDescripcionTerritorio.Name = "txtDescripcionTerritorio";
            txtDescripcionTerritorio.Size = new Size(137, 23);
            txtDescripcionTerritorio.TabIndex = 1;
            // 
            // Territorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 173);
            Controls.Add(txtDescripcionTerritorio);
            Controls.Add(label1);
            Name = "Territorios";
            Text = "Territorios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcionTerritorio;
    }
}