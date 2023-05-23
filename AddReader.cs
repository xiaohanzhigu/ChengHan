using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto;
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
    public partial class AddReader : Form
    {
        public AddReader()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
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
            string sql = $"select count(*) from t_reader where id = '{id_tb.Text.Trim()}' ";
            cmd.CommandText = sql;
            if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
            {
                conn.Close();
                MessageBox.Show("借阅编号已存在");
                return;
            }
            string sex = "男";
            if (woman_rb.Checked)
            {
                sex = "女";
            }
            string brith = brith_dtp.Value.ToShortDateString();
            brith = brith.Replace("/", "-");
            sql = $"insert into t_reader values({id_tb.Text.Trim()}, '{name_tb.Text.Trim()}', '{sex}', '{brith}')";
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() > 0)
            {
                this.DialogResult= DialogResult.OK;
            } else
            {
                MessageBox.Show("添加失败");
            }
            conn.Close();
        }
    }
}
