using MySql.Data.MySqlClient;
using System.Data;

namespace ChengHan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;database=db_bms;user ID=root;password=123456;sslmode=none;allowPublicKeyRetrieval=true");
            con.Open();
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand= cmd;

            string sql = $"select * from t_user where username = '{txtUname.Text.Trim()}' and password = '{txtPwd.Text.Trim()}'";

            cmd.CommandText = sql;

            adapter.Fill(table);

            con.Clone(); 

            if (table.Rows.Count > 0)
            {
                us.uid = table.Rows[0]["id"].ToString();
                us.username = table.Rows[0]["username"].ToString();
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
            else
            {
                MessageBox.Show("’À∫≈√‹¬Î¥ÌŒÛ", "µ«¬º ß∞‹", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}