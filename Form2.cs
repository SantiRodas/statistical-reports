using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statistical_reports
{
    public partial class Form2 : Form
    {
        private DataTable dataTable;
        public Form2(DataTable dt)
        {
            InitializeComponent();

            Hashtable dic = new Hashtable();

            DataRowCollection rows = dt.Rows;

            foreach (DataRow dr in rows)
            {
                object[] data = dr.ItemArray;


                if ((((string)data[4]).Trim()).Equals("Municipio")) {
                    if (!dic.ContainsKey((string)data[2]))
                    {
                        dic.Add((string)data[2], 1);
                    }
                    else
                    {
                        int count = (int)dic[(string)data[2]];
                        count++;

                        dic[(string)data[2]] = count;
                    }


                }

            }

            IEnumerator en = dic.Keys.GetEnumerator();

            bool check = en.MoveNext();

            List<KeyValuePair<int,string>> list = new List<KeyValuePair<int,string>>();

            chart1.Titles.Add("Report 2");

            while (check)
            {
                string department = (string)en.Current;

                list.Add(new KeyValuePair<int, string>((int)dic[department], department));

                check = en.MoveNext();

            }

            list.Sort(Compare1);

            int count2 = 0;

            for (int i = 12; i < list.Count; i++)
            {
                count2 += list[i].Key;
            }

            chart1.Series["s1"].Points.AddXY("OTHERS", count2);

            for(int i = 0; i < list.Count && i < 12; i++)
            {
                chart1.Series["s1"].Points.AddXY(list[i].Value, list[i].Key);
            }

            chart1.Series["s1"].Label = "#VALY";
            chart1.Series["s1"].LegendText = "#VALX";
        }

        static int Compare1(KeyValuePair<int, string> a, KeyValuePair<int, string> b)
        {
            int compare = a.Key.CompareTo(b.Key);

            if (compare == 0)
            {
                return -1*a.Value.CompareTo(b.Value);
            }
            else
            {
                return -1*compare;
            }
        }

    }
}
