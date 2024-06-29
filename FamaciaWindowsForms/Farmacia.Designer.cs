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
            btnTerminarPedido = new Button();
            lblSucursal = new Label();
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
            txtNombreMedicamento = new TextBox();
            btnAgregarProducto = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nmCantidadProducto = new NumericUpDown();
            cbTipoMedicamento = new ComboBox();
            pnlSucursal = new Panel();
            chkSecundaria = new CheckBox();
            chkPrincipal = new CheckBox();
            tmrFechaHora = new System.Windows.Forms.Timer(components);
            pnlDistribuidor = new Panel();
            label5 = new Label();
            label6 = new Label();
            lblDistribuidor = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblProductos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblHistoricoPedidos).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmCantidadProducto).BeginInit();
            pnlSucursal.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDistribuidor);
            panel1.Controls.Add(btnTerminarPedido);
            panel1.Controls.Add(lblSucursal);
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
            // btnTerminarPedido
            // 
            btnTerminarPedido.Location = new Point(373, 352);
            btnTerminarPedido.Name = "btnTerminarPedido";
            btnTerminarPedido.Size = new Size(75, 23);
            btnTerminarPedido.TabIndex = 8;
            btnTerminarPedido.Text = "Finalizar";
            btnTerminarPedido.UseVisualStyleBackColor = true;
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
            tblProductos.Size = new Size(436, 150);
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
            panel3.Controls.Add(txtNombreMedicamento);
            panel3.Controls.Add(btnAgregarProducto);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(nmCantidadProducto);
            panel3.Controls.Add(cbTipoMedicamento);
            panel3.Location = new Point(12, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 170);
            panel3.TabIndex = 2;
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new Point(16, 39);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new Size(439, 23);
            txtNombreMedicamento.TabIndex = 7;
            txtNombreMedicamento.KeyPress += txtNombreMedicamento_KeyPress;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(379, 137);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
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
            // nmCantidadProducto
            // 
            nmCantidadProducto.Location = new Point(16, 139);
            nmCantidadProducto.Name = "nmCantidadProducto";
            nmCantidadProducto.Size = new Size(120, 23);
            nmCantidadProducto.TabIndex = 2;
            // 
            // cbTipoMedicamento
            // 
            cbTipoMedicamento.FormattingEnabled = true;
            cbTipoMedicamento.Location = new Point(17, 84);
            cbTipoMedicamento.Name = "cbTipoMedicamento";
            cbTipoMedicamento.Size = new Size(438, 23);
            cbTipoMedicamento.TabIndex = 1;
            cbTipoMedicamento.SelectedIndexChanged += cbTipoMedicamento_SelectedIndexChanged;
            // 
            // pnlSucursal
            // 
            pnlSucursal.BorderStyle = BorderStyle.FixedSingle;
            pnlSucursal.Controls.Add(chkSecundaria);
            pnlSucursal.Controls.Add(chkPrincipal);
            pnlSucursal.Location = new Point(12, 140);
            pnlSucursal.Name = "pnlSucursal";
            pnlSucursal.Size = new Size(476, 69);
            pnlSucursal.TabIndex = 3;
            // 
            // chkSecundaria
            // 
            chkSecundaria.AutoSize = true;
            chkSecundaria.Location = new Point(17, 36);
            chkSecundaria.Name = "chkSecundaria";
            chkSecundaria.Size = new Size(84, 19);
            chkSecundaria.TabIndex = 1;
            chkSecundaria.Text = "Secundaria";
            chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // chkPrincipal
            // 
            chkPrincipal.AutoSize = true;
            chkPrincipal.Location = new Point(17, 11);
            chkPrincipal.Name = "chkPrincipal";
            chkPrincipal.Size = new Size(72, 19);
            chkPrincipal.TabIndex = 0;
            chkPrincipal.Text = "Principal";
            chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // tmrFechaHora
            // 
            tmrFechaHora.Enabled = true;
            tmrFechaHora.Tick += tmrFechaHora_Tick;
            // 
            // pnlDistribuidor
            // 
            pnlDistribuidor.BorderStyle = BorderStyle.FixedSingle;
            pnlDistribuidor.Location = new Point(12, 44);
            pnlDistribuidor.Name = "pnlDistribuidor";
            pnlDistribuidor.Size = new Size(476, 72);
            pnlDistribuidor.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 25);
            label5.Name = "label5";
            label5.Size = new Size(72, 16);
            label5.TabIndex = 5;
            label5.Text = "Distribuidor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 121);
            label6.Name = "label6";
            label6.Size = new Size(56, 16);
            label6.TabIndex = 6;
            label6.Text = "Sucursal";
            // 
            // lblDistribuidor
            // 
            lblDistribuidor.AutoSize = true;
            lblDistribuidor.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistribuidor.Location = new Point(138, 110);
            lblDistribuidor.Name = "lblDistribuidor";
            lblDistribuidor.Size = new Size(52, 18);
            lblDistribuidor.TabIndex = 9;
            lblDistribuidor.Text = "label11";
            // 
            // Farmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 609);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pnlDistribuidor);
            Controls.Add(pnlSucursal);
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
            ((System.ComponentModel.ISupportInitialize)nmCantidadProducto).EndInit();
            pnlSucursal.ResumeLayout(false);
            pnlSucursal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel pnlSucursal;
        private ComboBox cbTipoMedicamento;
        private Label label1;
        private NumericUpDown nmCantidadProducto;
        private Label label4;
        private Button btnAgregarProducto;
        private Label label3;
        private Label label2;
        private Label label7;
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
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmrFechaHora;
        private Panel pnlDistribuidor;
        private Label label5;
        private Label label6;
        private CheckBox chkSecundaria;
        private CheckBox chkPrincipal;
        private TextBox txtNombreMedicamento;
        private Button btnTerminarPedido;
        private Label lblDistribuidor;
    }
}
