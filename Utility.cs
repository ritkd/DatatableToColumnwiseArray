using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatableToColumnwiseArray
{
    static class Utility
    {
        internal static DataTable GetDataTableWithMockDataExtension(this DataTable dt, int RowCOunt, int ColCount)
        {
            for (int i = 0; i < ColCount; i++)
            {
                dt.Columns.Add("col" + (i + 1).ToString());
            }
            for (int i = 0; i < RowCOunt; i++)
            {
                DataRow dr = dt.NewRow();
                dr["col1"] = "sdfdsfsfsef";
                dr["col2"] = "rtytetytrytr";
                dr["col3"] = "xcvxcvcvxvxcxcxc";
                dr["col4"] = "asdasdasdasdadasdasd";
                dr["col5"] = "qweqweweqweqwewewewwqeweqwe";
                dr["col6"] = "pouioioyioiyoyuyuyuyuiuyijtyuti";
                dr["col7"] = "fmbhvnbncngnbncnggngngncgngcccngcgcn";
                dr["col8"] = "fxxcchchgvuvvvvjhbjvccchjhvvcfcchjhbbkbjh";
                dr["col9"] = "osidufohofosdhvhrohvohohwdhvsdhvhohsdohcosdhco";
                dr["col10"] = "lkljsdlklkjljvldslkjlkfjldskjldjlkdjlkcjlzxkjclkzxjl";
                dt.Rows.Add(dr);
            }
            return dt;
        }

        internal static List<string[]> ToColumnwiseArray(this DataTable dt)
        {
            List<string[]> ColumnwiseArray = new List<string[]>();
            foreach (DataColumn column in dt.Columns)
            {
                List<string> col = (from Products in dt.AsEnumerable()
                                    select Products.Field<string>(column.ColumnName)).ToList();
                string[] arr = col.ToArray();
                ColumnwiseArray.Add(arr);
            }
            return ColumnwiseArray;
        }    
    }
}
