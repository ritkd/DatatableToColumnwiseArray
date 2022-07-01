using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DatatableToColumnwiseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create datatable and fill with dummydata
            int Rows = 10; //1 million
            int Cols = 10;
            DataTable MockTable = new DataTable().GetDataTableWithMockDataExtension(Rows,Cols);
            List<string[]> Result =MockTable.ToColumnwiseArray();
             
            foreach (string[] item in Result)
            {
                foreach (string val in item)
                {
                    Console.WriteLine(val,"/n");
                }
                Console.WriteLine("/n/n");
            }
            Console.ReadKey();
        }
    }
}
