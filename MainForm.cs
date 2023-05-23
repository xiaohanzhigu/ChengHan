using ChengHan.View;

namespace ChengHan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            account_status.Text = "当前用户" + us.username;
            this.TopMost = false;
            Thread t = new Thread(new ThreadStart(run));
            t.Start();
        }

        private void run()
        {
            while (true)
            {
                this.BeginInvoke(new EventHandler(delegate
                {
                    time_statu.Text = DateTime.Now.ToString();
                }));
                Thread.Sleep(1000);
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要退出", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Environment.Exit(1);
            }
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            ReaderManage readerManage = new ReaderManage();
            readerManage.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new BookManager().ShowDialog();
        }
    }
}
