using MySql.Data.MySqlClient;
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
    public partial class ReaderManage : Form
    {
        public ReaderManage()
        {
            InitializeComponent();
        }

        private void ReaderManage_Load(object sender, EventArgs e)
        {
            initdata();
        }

        private void initdata()
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=db_bms;user ID=root;password=123456;sslmode=none;allowPublicKeyRetrieval=true");
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            String sql = "select id, name, sex, DATE_FORMAT(birth, '%Y-%m-%d') as birth from t_reader";
            command.CommandText = sql;
            adapter.Fill(dt);
            conn.Close();
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem li = listView1.Items.Add(dt.Rows[i]["id"].ToString());
                li.SubItems.Add(dt.Rows[i]["name"].ToString());
                li.SubItems.Add(dt.Rows[i]["sex"].ToString());
                li.SubItems.Add(dt.Rows[i]["birth"].ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择一个删除项");
            }

            string readerId = listView1.SelectedItems[0].Text;

            if (MessageBox.Show("是否删除", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;database=db_bms;user ID=root;password=123456;sslmode=none;allowPublicKeyRetrieval=true");
                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                string sql = $"delete from t_reader where id = '{readerId}'";
                command.CommandText = sql;
                if (command.ExecuteNonQuery() > 0)
                {
                    initdata();
                    MessageBox.Show("删除成功");
                } else
                {
                    MessageBox.Show("删除失败");
                }
                conn.Close();
            }
        }
    }
}
