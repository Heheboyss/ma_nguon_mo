namespace trangchugv
{
    public partial class frmtrangchugv : Form
    {
        public frmtrangchugv()
        {
            InitializeComponent();
        }

        private Form currentformchild;
        private void Openformchild(Form childform)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlqlsvgv.Controls.Add(childform);
            pnlqlsvgv.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void btnqlsvgv_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqlsvgv());
        }
    }
}