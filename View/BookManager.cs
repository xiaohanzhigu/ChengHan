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
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            if (addBook.ShowDialog() == DialogResult.OK)
            {
                initData();
                MessageBox.Show("添加成功");
            }
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            List<Book> list = BookOperator.GetBookList();
            listView1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Book book = list[i];
                ListViewItem il = listView1.Items.Add(book.code);
                il.SubItems.Add(book.bookName);
                il.SubItems.Add(book.author);
                il.SubItems.Add(book.publisher);
                il.SubItems.Add(book.pubDate.ToString());
                il.SubItems.Add(book.price.ToString());
                il.SubItems.Add(book.ISBN);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) 
            {
                MessageBox.Show("请选择一行");
                return;
            }
            if (MessageBox.Show("真的要删除吗", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            string code = listView1.SelectedItems[0].SubItems[0].Text;
            if (BookOperator.DelBook(code))
            {
                initData();
                MessageBox.Show("删除成功");
            } else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行");
                return;
            }
            string code = listView1.SelectedItems[0].SubItems[0].Text;
            UpdateBook updateBook = new UpdateBook();
            updateBook.code= code;
            if (updateBook.ShowDialog() == DialogResult.OK)
            {
                initData();
                MessageBox.Show("修改成功");
            }

        }
    }
}
