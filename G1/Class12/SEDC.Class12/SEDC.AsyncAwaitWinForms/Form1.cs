namespace SEDC.AsyncAwaitWinForms
{
    public partial class Form1 : Form
    {
        private string Message = "No messages yet!";

        public void SendMessage(string message)
        {
            lblMessage.Text = "Message sent with sync!";
            Thread.Sleep(10000);
            Message = message;
        }

        public async Task SendMessageAsync(string message)
        {
            //lblMessage.Text = "Message sent with async!";
            await Task.Run(() =>
            {
                Thread.Sleep(10000);
                Message = message;
            });
            Message = message;
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetSync_Click(object sender, EventArgs e)
        {
            SendMessage("This message is sent by using sync programming!");
        }

        private async void btnGetAsync_Click(object sender, EventArgs e)
        {
            await SendMessageAsync("Hello this is async call!");
        }

        private void btnCheckMessage_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Message;
        }

        
    }
}