using ChengHan.DLL;
using ChengHan.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChengHan.View
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.code = id_tb.Text.ToString();
            book.bookName = name_tb.Text.ToString();
            book.author = author_tb.Text.ToString();
            book.publisher = pu_tb.Text.ToString();
            book.pubDate= pd_dp.Value.ToShortDateString();
            book.price = Convert.ToDouble(price_tb.Text);
            book.ISBN = ISBN_tb.Text.ToString();
            if (BookOperator.AddBook(book))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            
        }
    }
}
