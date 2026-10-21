using System.ComponentModel;

namespace Ejercicio_Cafeteria
{
    public partial class frmMenu : Form
    {
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Pedido> ListaPedidos { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Producto> ListaProductos { get; set; }
        public frmMenu()
        {
            InitializeComponent();
            ListaPedidos = new BindingList<Pedido>();
            ListaProductos = new List<Producto>();
            dataGridView1.DataSource = ListaPedidos;
        }

        private void SeleccionarProducto(object sender, EventArgs e)
        {
            switch (cmbListaProductos.SelectedIndex)
            {
                case 0:
                    txtPrecio.Text = ListaProductos[0].Precio.ToString();
                    break;
                case 1:
                    txtPrecio.Text = ListaProductos[1].Precio.ToString();
                    break;
                case 2:
                    txtPrecio.Text = ListaProductos[2].Precio.ToString();
                    break;
                case 3:
                    txtPrecio.Text = ListaProductos[3].Precio.ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventario();

            cmbListaProductos.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbListaProductos.Items.Add(ListaProductos[0]);
            this.cmbListaProductos.Items.Add(ListaProductos[1]);
            this.cmbListaProductos.Items.Add(ListaProductos[2]);
            this.cmbListaProductos.Items.Add(ListaProductos[3]);
            
            lblTotal.Text = "Total: $0.00";
        }

        public void inventario()
        {
            ListaProductos.Add(new Producto("Café", 30.00m));
            ListaProductos.Add(new Producto("Té", 25.00m));
            ListaProductos.Add(new Producto("Sandwich", 55.00m));
            ListaProductos.Add(new Producto("Galletas", 20.00m));

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbListaProductos.SelectedItem != null && !string.IsNullOrWhiteSpace(numCantidad.Text))
            {
                Producto productoSeleccionado = (Producto)cmbListaProductos.SelectedItem;
                int cantidad = int.Parse(numCantidad.Text);
                bool paraLlevar = ckbParaLlevar.Checked;
                Pedido nuevoPedido = new Pedido(productoSeleccionado, cantidad, paraLlevar);
                ListaPedidos.Add(nuevoPedido);
                // Limpiar los campos después de agregar el pedido
                lblTotal.Text = $"Total: ${ListaPedidos.Sum(p => p.Subtotal):0.00}";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto y especifique la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVaciar_clik(object sender, EventArgs e)
        {
            if (ListaPedidos != null && ListaPedidos.Count == 0)
            {
                string mensaje = "La lista de pedidos ya está vacía.";
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea vaciar la lista de pedidos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    ListaPedidos.Clear();
                    lblTotal.Text = "Total: $0.00";
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar el pedido seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Pedido pedidoSeleccionado = row.DataBoundItem as Pedido;
                    if (confirmacion == DialogResult.Yes)
                    {
                        if (pedidoSeleccionado != null)
                        {
                            ListaPedidos.Remove(pedidoSeleccionado);
                            lblTotal.Text = $"Total: ${ListaPedidos.Sum(p => p.Subtotal):0.00}";
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
