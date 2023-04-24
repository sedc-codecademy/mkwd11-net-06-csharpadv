namespace SEDC.WinFormsApp
{
    public partial class Form1 : Form
    {

        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnSave.Click += BtnSave_CountClick;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtSomething.Text;
            txtSomething.Text = string.Empty;
        }

        private void BtnSave_CountClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is windows box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblTimesClicked.Text = (++count).ToString();
        }
    }
}