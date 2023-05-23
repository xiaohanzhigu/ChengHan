using ChengHan.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChengHan.DLL
{
    internal class BookOperator
    {
        public static List<Book> GetBookList()
        {
            List<Book> list = new List<Book>();
            string sql = "select * from t_book";
            DataTable table = SqlHelper.GetTable(sql);
            if (table != null)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Book book= new Book();
                    book.code = table.Rows[i]["code"].ToString();
                    book.bookName = table.Rows[i]["bookName"].ToString();
                    book.author = table.Rows[i]["author"].ToString();
                    book.publisher = table.Rows[i]["publisher"].ToString();
                    book.pubDate = table.Rows[i]["pubDate"].ToString();
                    book.price = Convert.ToDouble(table.Rows[i]["price"].ToString());
                    book.ISBN = table.Rows[i]["ISBN"].ToString(); 
                    list.Add(book);
                }
            }
            return list;
        }

        public static Book GetBook(string code)
        {
            string sql = $"select * from t_book where code = '{code}'";
            DataTable table  = SqlHelper.GetTable(sql);
            Book book = new Book();
            if (table != null && table.Rows.Count > 0)
            {
                book.code = table.Rows[0]["code"].ToString();
                book.bookName = table.Rows[0]["bookName"].ToString();
                book.author = table.Rows[0]["author"].ToString();
                book.publisher = table.Rows[0]["publisher"].ToString();
                book.pubDate = table.Rows[0]["pubDate"].ToString();
                book.price = Convert.ToDouble(table.Rows[0]["price"].ToString());
                book.ISBN = table.Rows[0]["ISBN"].ToString();
            } else
            {
                book = null;
            }

            return book;
        }

        public static bool DelBook(string code)
        {
            string sql = $"delete from t_book where code = '{code}'";
            int row = SqlHelper.ExeSql(sql);
            return (row > 0);
        }

        public static bool AddBook(Book book)
        {
            string sql = $@"insert into t_book values('{book.code}', '{book.bookName}', '{book.author}','{book.publisher}', '{book.pubDate.ToString()}', {book.price}, '{book.ISBN}')";
            int row = SqlHelper.ExeSql(sql);
            return (row > 0);
        }

        public static bool UpdateBook(Book book)
        {
            string sql = $@"update t_book set author='{book.author}', bookName='{book.bookName}', publisher='{book.publisher}', pubDate='{book.pubDate.ToString()}', price={book.price}, ISBN='{book.ISBN}' where code= '{book.code}'";
            int row = SqlHelper.ExeSql(sql);
            return (row > 0);
        }
    }
}
