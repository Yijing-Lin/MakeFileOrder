using System;
using System.Collections;
using System.Windows.Forms;

namespace MakeFileOrder
{
    class ListViewItemComparerNum: IComparer
    {
        public bool sort_b;
        public SortOrder order = SortOrder.Ascending;

        private int col;

        public ListViewItemComparerNum()
        {
            col = 0;
        }

        public ListViewItemComparerNum(int column, bool sort)
        {
            col = column;
            sort_b = sort;
        }

        public int Compare(object x, object y)
        {
            decimal d1 = Convert.ToDecimal(((ListViewItem)x).SubItems[col].Text);
            decimal d2 = Convert.ToDecimal(((ListViewItem)y).SubItems[col].Text);
            if (sort_b)
            {
                return decimal.Compare(d1, d2);
            }
            else
            {
                return decimal.Compare(d2, d1);
            }
        }
    }
}
