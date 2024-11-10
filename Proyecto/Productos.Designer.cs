namespace Proyecto
{
    partial class Productos
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            txtNombreProducto = new TextBox();
            txtCantidadUnidad = new TextBox();
            label2 = new Label();
            txtUnidadesEnStock = new TextBox();
            label3 = new Label();
            txtPrecioUnitario = new TextBox();
            label4 = new Label();
            ReordenarNivel = new TextBox();
            label5 = new Label();
            UnidadesEnOrden = new TextBox();
            label6 = new Label();
            txtDescontinuado = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 27);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(70, 55);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // txtCantidadUnidad
            // 
            txtCantidadUnidad.Location = new Point(70, 126);
            txtCantidadUnidad.Name = "txtCantidadUnidad";
            txtCantidadUnidad.Size = new Size(100, 23);
            txtCantidadUnidad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 99);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad por unidad";
            // 
            // txtUnidadesEnStock
            // 
            txtUnidadesEnStock.Location = new Point(70, 271);
            txtUnidadesEnStock.Name = "txtUnidadesEnStock";
            txtUnidadesEnStock.Size = new Size(100, 23);
            txtUnidadesEnStock.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 244);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 6;
            label3.Text = "Unidades en stock";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(70, 200);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(100, 23);
            txtPrecioUnitario.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 172);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Precio unitario";
            // 
            // ReordenarNivel
            // 
            ReordenarNivel.Location = new Point(252, 126);
            ReordenarNivel.Name = "ReordenarNivel";
            ReordenarNivel.Size = new Size(100, 23);
            ReordenarNivel.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 99);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 10;
            label5.Text = "Reordenar nivel";
            // 
            // UnidadesEnOrden
            // 
            UnidadesEnOrden.Location = new Point(252, 55);
            UnidadesEnOrden.Name = "UnidadesEnOrden";
            UnidadesEnOrden.Size = new Size(100, 23);
            UnidadesEnOrden.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 27);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 8;
            label6.Text = "Unidades en orden";
            // 
            // txtDescontinuado
            // 
            txtDescontinuado.Location = new Point(258, 214);
            txtDescontinuado.Name = "txtDescontinuado";
            txtDescontinuado.Size = new Size(100, 23);
            txtDescontinuado.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 187);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 12;
            label7.Text = "Descontinuado";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescontinuado);
            Controls.Add(label7);
            Controls.Add(ReordenarNivel);
            Controls.Add(label5);
            Controls.Add(UnidadesEnOrden);
            Controls.Add(label6);
            Controls.Add(txtUnidadesEnStock);
            Controls.Add(label3);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(label4);
            Controls.Add(txtCantidadUnidad);
            Controls.Add(label2);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Name = "Productos";
            Text = "Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox txtNombreProducto;
        private TextBox txtCantidadUnidad;
        private Label label2;
        private TextBox txtUnidadesEnStock;
        private Label label3;
        private TextBox txtPrecioUnitario;
        private Label label4;
        private TextBox ReordenarNivel;
        private Label label5;
        private TextBox UnidadesEnOrden;
        private Label label6;
        private TextBox txtDescontinuado;
        private Label label7;
    }
}