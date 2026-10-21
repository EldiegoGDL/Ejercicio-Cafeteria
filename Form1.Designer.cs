namespace Ejercicio_Cafeteria
{
    partial class frmMenu
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
            dataGridView1 = new DataGridView();
            lbProducto = new Label();
            lbPrecio = new Label();
            lbCantidad = new Label();
            ckbParaLlevar = new CheckBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVaciar = new Button();
            grbMiniMenu = new GroupBox();
            numCantidad = new NumericUpDown();
            txtPrecio = new TextBox();
            cmbListaProductos = new ComboBox();
            lbRegistroPedido = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grbMiniMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(289, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(499, 206);
            dataGridView1.TabIndex = 0;
            // 
            // lbProducto
            // 
            lbProducto.AutoSize = true;
            lbProducto.Location = new Point(0, 19);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(56, 15);
            lbProducto.TabIndex = 1;
            lbProducto.Text = "Producto";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(0, 55);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(85, 15);
            lbPrecio.TabIndex = 1;
            lbPrecio.Text = "Precio Unitario";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(0, 88);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(55, 15);
            lbCantidad.TabIndex = 1;
            lbCantidad.Text = "Cantidad";
            // 
            // ckbParaLlevar
            // 
            ckbParaLlevar.AutoSize = true;
            ckbParaLlevar.Location = new Point(6, 123);
            ckbParaLlevar.Name = "ckbParaLlevar";
            ckbParaLlevar.Size = new Size(175, 19);
            ckbParaLlevar.TabIndex = 2;
            ckbParaLlevar.Text = "Para llevar (+ $5 por pedido)";
            ckbParaLlevar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(4, 161);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(85, 161);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(166, 161);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(75, 23);
            btnVaciar.TabIndex = 3;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_clik;
            // 
            // grbMiniMenu
            // 
            grbMiniMenu.Controls.Add(numCantidad);
            grbMiniMenu.Controls.Add(txtPrecio);
            grbMiniMenu.Controls.Add(cmbListaProductos);
            grbMiniMenu.Controls.Add(btnVaciar);
            grbMiniMenu.Controls.Add(lbProducto);
            grbMiniMenu.Controls.Add(lbPrecio);
            grbMiniMenu.Controls.Add(lbCantidad);
            grbMiniMenu.Controls.Add(ckbParaLlevar);
            grbMiniMenu.Controls.Add(btnEliminar);
            grbMiniMenu.Controls.Add(btnAgregar);
            grbMiniMenu.Location = new Point(12, 12);
            grbMiniMenu.Name = "grbMiniMenu";
            grbMiniMenu.Size = new Size(261, 206);
            grbMiniMenu.TabIndex = 4;
            grbMiniMenu.TabStop = false;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(85, 81);
            numCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.ReadOnly = true;
            numCantidad.Size = new Size(150, 23);
            numCantidad.TabIndex = 6;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(85, 52);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(150, 23);
            txtPrecio.TabIndex = 5;
            // 
            // cmbListaProductos
            // 
            cmbListaProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListaProductos.FormattingEnabled = true;
            cmbListaProductos.Location = new Point(85, 16);
            cmbListaProductos.Name = "cmbListaProductos";
            cmbListaProductos.Size = new Size(150, 23);
            cmbListaProductos.TabIndex = 4;
            cmbListaProductos.SelectedIndexChanged += SeleccionarProducto;
            // 
            // lbRegistroPedido
            // 
            lbRegistroPedido.AutoSize = true;
            lbRegistroPedido.Location = new Point(289, 12);
            lbRegistroPedido.Name = "lbRegistroPedido";
            lbRegistroPedido.Size = new Size(103, 15);
            lbRegistroPedido.TabIndex = 5;
            lbRegistroPedido.Text = "Pedido Registrado";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(289, 255);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 288);
            Controls.Add(lblTotal);
            Controls.Add(lbRegistroPedido);
            Controls.Add(grbMiniMenu);
            Controls.Add(dataGridView1);
            Name = "frmMenu";
            Text = "Pedidos Cafeteria";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grbMiniMenu.ResumeLayout(false);
            grbMiniMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbProducto;
        private Label lbPrecio;
        private Label lbCantidad;
        private CheckBox ckbParaLlevar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVaciar;
        private GroupBox grbMiniMenu;
        private TextBox txtPrecio;
        private ComboBox cmbListaProductos;
        private Label lbRegistroPedido;
        private NumericUpDown numCantidad;
        private Label lblTotal;
    }
}
