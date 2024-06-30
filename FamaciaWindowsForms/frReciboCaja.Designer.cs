namespace FamaciaWindowsForms
{
    partial class frReciboCaja
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblDistribuidor = new Label();
            lblSucursal = new Label();
            lblDireccion = new Label();
            lblFechaHora = new Label();
            tblMedicamentos = new DataGridView();
            Tipo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tblMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 26);
            label1.Name = "label1";
            label1.Size = new Size(359, 37);
            label1.TabIndex = 0;
            label1.Text = "Farmacia UNIR S.A.S";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(319, 63);
            label2.Name = "label2";
            label2.Size = new Size(160, 22);
            label2.TabIndex = 1;
            label2.Text = "nit 999.999.999";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(217, 85);
            label3.Name = "label3";
            label3.Size = new Size(370, 22);
            label3.TabIndex = 2;
            label3.Text = "Calle 123 # 45 - 67 Bogota, Colombia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(140, 22);
            label4.TabIndex = 3;
            label4.Text = "Distribuidor:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 4;
            label5.Text = "Sucursal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 197);
            label6.Name = "label6";
            label6.Size = new Size(110, 22);
            label6.TabIndex = 5;
            label6.Text = "Direccion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 230);
            label7.Name = "label7";
            label7.Size = new Size(140, 22);
            label7.TabIndex = 6;
            label7.Text = "Fecha y Hora:";
            // 
            // lblDistribuidor
            // 
            lblDistribuidor.AutoSize = true;
            lblDistribuidor.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistribuidor.Location = new Point(191, 131);
            lblDistribuidor.Name = "lblDistribuidor";
            lblDistribuidor.Size = new Size(0, 22);
            lblDistribuidor.TabIndex = 7;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(191, 163);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(0, 22);
            lblSucursal.TabIndex = 8;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(191, 197);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(0, 22);
            lblDireccion.TabIndex = 9;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaHora.Location = new Point(191, 230);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 22);
            lblFechaHora.TabIndex = 10;
            // 
            // tblMedicamentos
            // 
            tblMedicamentos.AllowUserToAddRows = false;
            tblMedicamentos.AllowUserToDeleteRows = false;
            tblMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMedicamentos.Columns.AddRange(new DataGridViewColumn[] { Tipo, Producto, Cantidad });
            tblMedicamentos.Location = new Point(13, 278);
            tblMedicamentos.Name = "tblMedicamentos";
            tblMedicamentos.ReadOnly = true;
            tblMedicamentos.Size = new Size(775, 190);
            tblMedicamentos.TabIndex = 11;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // frReciboCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(tblMedicamentos);
            Controls.Add(lblFechaHora);
            Controls.Add(lblDireccion);
            Controls.Add(lblSucursal);
            Controls.Add(lblDistribuidor);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frReciboCaja";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "frReciboCaja";
            ((System.ComponentModel.ISupportInitialize)tblMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public Label lblDistribuidor;
        public Label lblSucursal;
        public Label lblDireccion;
        public Label lblFechaHora;
        public DataGridView tblMedicamentos;
        public DataGridViewTextBoxColumn Tipo;
        public DataGridViewTextBoxColumn Producto;
        public DataGridViewTextBoxColumn Cantidad;
    }
}