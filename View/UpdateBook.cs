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
    public partial class UpdateBook : Form
    {
        public string code = "";
        public UpdateBook()
        {
            InitializeComponent();
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
            book.publisher = cps_tb.Text.ToString();
            book.pubDate = date_dtp.Value.ToShortDateString();
            book.price = Convert.ToDouble(price_tb.Text);
            book.ISBN = ISBN_tb.Text.ToString();
            if (BookOperator.UpdateBook(book))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void UpdateBook__Load(object sender, EventArgs e)
        {
            if (code != "")
            {
                Book book = BookOperator.GetBook(code);
                if (book != null)
                {
                    id_tb.Text = code;
                    name_tb.Text = book.bookName;
                    author_tb.Text = book.author;
                    cps_tb.Text = book.publisher;
                    date_dtp.Value = Convert.ToDateTime(book.pubDate);
                    price_tb.Text = book.price.ToString();
                    ISBN_tb.Text = book.ISBN;
                }
            }
        }
    }
}
