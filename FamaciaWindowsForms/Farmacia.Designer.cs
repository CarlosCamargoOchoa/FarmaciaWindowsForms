namespace FamaciaWindowsForms
{
    partial class Farmacia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblSucursal = new Label();
            lblDistribuidor = new Label();
            lblFechaHora = new Label();
            tblProductos = new DataGridView();
            Tipo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            tblHistoricoPedidos = new DataGridView();
            Distribuidor = new DataGridViewTextBoxColumn();
            Sucursal = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            CantidadProductos = new DataGridViewTextBoxColumn();
            label7 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            cbCantidadUnidades = new ComboBox();
            txtNombreMedicamento = new TextBox();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            tmrFechaHora = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblProductos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblHistoricoPedidos).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblSucursal);
            panel1.Controls.Add(lblDistribuidor);
            panel1.Controls.Add(lblFechaHora);
            panel1.Controls.Add(tblProductos);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(494, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 385);
            panel1.TabIndex = 0;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(136, 140);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(0, 18);
            lblSucursal.TabIndex = 7;
            // 
            // lblDistribuidor
            // 
            lblDistribuidor.AutoSize = true;
            lblDistribuidor.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistribuidor.Location = new Point(136, 109);
            lblDistribuidor.Name = "lblDistribuidor";
            lblDistribuidor.Size = new Size(0, 18);
            lblDistribuidor.TabIndex = 6;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaHora.Location = new Point(136, 79);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 18);
            lblFechaHora.TabIndex = 5;
            // 
            // tblProductos
            // 
            tblProductos.AllowUserToAddRows = false;
            tblProductos.AllowUserToDeleteRows = false;
            tblProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblProductos.Columns.AddRange(new DataGridViewColumn[] { Tipo, Nombre, Cantidad });
            tblProductos.Location = new Point(12, 172);
            tblProductos.Name = "tblProductos";
            tblProductos.ReadOnly = true;
            tblProductos.Size = new Size(436, 203);
            tblProductos.TabIndex = 4;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 139);
            label10.Name = "label10";
            label10.Size = new Size(83, 19);
            label10.TabIndex = 3;
            label10.Text = "Sucursal:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 108);
            label9.Name = "label9";
            label9.Size = new Size(111, 19);
            label9.TabIndex = 2;
            label9.Text = "Distribuidor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 76);
            label8.Name = "label8";
            label8.Size = new Size(118, 19);
            label8.TabIndex = 1;
            label8.Text = "Fecha y hora:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(307, 39);
            label4.TabIndex = 0;
            label4.Text = "Detalle del pedido";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tblHistoricoPedidos);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(12, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 197);
            panel2.TabIndex = 1;
            // 
            // tblHistoricoPedidos
            // 
            tblHistoricoPedidos.AllowUserToAddRows = false;
            tblHistoricoPedidos.AllowUserToDeleteRows = false;
            tblHistoricoPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblHistoricoPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblHistoricoPedidos.Columns.AddRange(new DataGridViewColumn[] { Distribuidor, Sucursal, Fecha, CantidadProductos });
            tblHistoricoPedidos.Location = new Point(16, 31);
            tblHistoricoPedidos.Name = "tblHistoricoPedidos";
            tblHistoricoPedidos.ReadOnly = true;
            tblHistoricoPedidos.Size = new Size(914, 150);
            tblHistoricoPedidos.TabIndex = 1;
            // 
            // Distribuidor
            // 
            Distribuidor.HeaderText = "Distribuidor";
            Distribuidor.Name = "Distribuidor";
            Distribuidor.ReadOnly = true;
            Distribuidor.Resizable = DataGridViewTriState.False;
            // 
            // Sucursal
            // 
            Sucursal.HeaderText = "Sucursal";
            Sucursal.Name = "Sucursal";
            Sucursal.ReadOnly = true;
            Sucursal.Resizable = DataGridViewTriState.False;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // CantidadProductos
            // 
            CantidadProductos.HeaderText = "Cantidad Productos";
            CantidadProductos.Name = "CantidadProductos";
            CantidadProductos.ReadOnly = true;
            CantidadProductos.Resizable = DataGridViewTriState.False;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 15);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 0;
            label7.Text = "Historial de pedidos";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(cbCantidadUnidades);
            panel3.Controls.Add(txtNombreMedicamento);
            panel3.Location = new Point(12, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 170);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(379, 137);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 121);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad de unidades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 66);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 4;
            label2.Text = "Tipo de medicamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre del medicamento";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(16, 139);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // cbCantidadUnidades
            // 
            cbCantidadUnidades.FormattingEnabled = true;
            cbCantidadUnidades.Location = new Point(17, 84);
            cbCantidadUnidades.Name = "cbCantidadUnidades";
            cbCantidadUnidades.Size = new Size(438, 23);
            cbCantidadUnidades.TabIndex = 1;
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new Point(16, 31);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new Size(438, 23);
            txtNombreMedicamento.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(12, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(476, 209);
            panel4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 112);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 1;
            label6.Text = "Sucursal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 16);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 0;
            label5.Text = "Distribuidor";
            // 
            // tmrFechaHora
            // 
            tmrFechaHora.Enabled = true;
            tmrFechaHora.Tick += tmrFechaHora_Tick;
            // 
            // Farmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 609);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Farmacia";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Farmacia";
            Load += Farmacia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblProductos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblHistoricoPedidos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ComboBox cbCantidadUnidades;
        private TextBox txtNombreMedicamento;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView tblHistoricoPedidos;
        private DataGridViewTextBoxColumn Distribuidor;
        private DataGridViewTextBoxColumn Sucursal;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn CantidadProductos;
        private DataGridView tblProductos;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private Label lblSucursal;
        private Label lblDistribuidor;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmrFechaHora;
    }
}
