using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater.Module
{
    class MyModule
    {
        public static void fixColumnSize(DataGridView dgv)
        {
            int count = dgv.ColumnCount;
            for (int i = 0; i <= count - 1; i++)
            {
                dgv.Columns[i].Width = dgv.Width / count;
            }
        }

    }
}
