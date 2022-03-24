using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakazLibruary
{
    public class ListOrder
    {
        public List<String> table1 = new List<string>();

        public ListOrder()
        {

        }

        public String updateTable()
        {
            String text = "";
            foreach (var item in table1)
            {
                text += item + " ";
            }
            return text;
        }

        public void Add(String val)
        {
            table1.Add(val);
            updateTable();
        }

        public void Delete(String val)
        {
            table1.Remove(val);
            updateTable();
        }
    }
}
