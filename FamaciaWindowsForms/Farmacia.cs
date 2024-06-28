namespace FamaciaWindowsForms
{
    public partial class Farmacia : Form
    {
        public Farmacia()
        {
            InitializeComponent();
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString(" yyyy - MM - dd HH:mm");
        }

        private void Farmacia_Load(object sender, EventArgs e)
        {
            tmrFechaHora.Interval = 1000;
            tmrFechaHora.Enabled = true;
        }
    }
}
