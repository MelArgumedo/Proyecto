namespace Proyecto
{
    partial class Región
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
            txtDescripcionRegion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción de la región";
            // 
            // txtDescripcionRegion
            // 
            txtDescripcionRegion.Location = new Point(23, 53);
            txtDescripcionRegion.Name = "txtDescripcionRegion";
            txtDescripcionRegion.Size = new Size(100, 23);
            txtDescripcionRegion.TabIndex = 1;
            // 
            // Región
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 188);
            Controls.Add(txtDescripcionRegion);
            Controls.Add(label1);
            Name = "Región";
            Text = "Región";
            Load += Región_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcionRegion;
    }
}