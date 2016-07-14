using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace inport
{
    class Program
    {
        static void Main(string[] args)
        {
            string con =
  @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\J00459735\Documents\Excel to SQL HSIS db - Final Copy.xlsx;" +
  @"Extended Properties='Excel 8.0;HDR=Yes;'";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var row1Col0 = dr[0];
                        Console.WriteLine(row1Col0);
                    }
                }
            }
        }
    }
}
