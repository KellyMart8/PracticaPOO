namespace pjVentaBoletas
{
    public partial class fmrBoletadeVenta : Form
    {
        double precio = 0;
        string producto = " ";

        public fmrBoletadeVenta()
        {
            InitializeComponent();
        }

        private void fmrBoletadeVenta_Load(object sender, EventArgs e)
        {
            DeterminarPrecio();
            CalcularImporte();
        }

        private void DeterminarPrecio()
        {
            // Capturando el tipo producto
            string TipoProducto = cboTipoProducto.SelectedIndex.ToString();

            //ASignamos el precio a la categoria seleccionada
            switch (TipoProducto)
            {
                case 0:
                    precio = 500; producto = "PS5 +1 MANDO DS5"; break;
                case 1:
                    precio = 619; producto = "PS4(1 TB) + MANDO DS4"; break;
                case 2:
                    precio = 69; producto = "MANDO PS5/DS5"; break;
                case 3:
                    precio = 60; producto = "MANDO PS4/DS4"; break;

            }
            lblPrecio.Text = precio.ToString("C");
        }

        private void CalcularImporte()
        {
            lblPrecio.Text = 
        }

        private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

