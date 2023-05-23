using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChengHan
{
    public partial class UpdateReader : Form
    {
        public string readerId = "";
        public UpdateReader()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateReader_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=db_bms;user ID=root;password=123456;sslmode=none;allowPublicKeyRetrieval=true;Charset=utf8mb4");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string sql = $"select * from t_reader where id = {readerId}";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand= cmd;
            cmd.CommandText= sql;
            adapter.Fill(table);
            conn.Close();
            if (table.Rows.Count == 0 )
            {
                MessageBox.Show("该编号不存在");
                this.Close();
            }
            id_tb.Text = table.Rows[0]["id"].ToString();
            name_tb.Text = table.Rows[0]["name"].ToString();
            if (table.Rows[0]["sex"].ToString() == "男")
                man_rb.Checked = true;
            else 
                woman_rb.Checked = true;
            brith_dtp.Value = Convert.ToDateTime(table.Rows[0]["birth"].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((name_tb.Text.Trim()).Length == 0)
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=db_bms;user ID=root;password=123456;sslmode=none;allowPublicKeyRetrieval=true;Charset=utf8mb4");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string sex = "男";
            if (woman_rb.Checked)
                sex = "女";
            string brith = brith_dtp.Value.ToShortDateString();
            brith = brith.Replace("/", "-");
            string sql = $"update t_reader set name = '{name_tb.Text.Trim()}', sex = '{sex}', birth = '{brith}' where id = {readerId}";
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            conn.Close();
        }
    }
}
