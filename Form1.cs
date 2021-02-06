using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace statistical_reports
{
    public partial class Form1 : Form
    {

        private DataTable dt;

        public Form1()
        {
            InitializeComponent();

            for (int i = 65; i <= 90; i ++)
            {

                comboBox1.Items.Add((char)i);

            }

            dt = new DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            label2.Text = openFileDialog1.FileName;

            string content = File.ReadAllText(openFileDialog1.FileName);

            string[] splitContent = content.Split('\n');

            string[] splitLine = splitContent[0].Split(',');

            dt.Columns.Add(splitLine[0]);
            dt.Columns.Add(splitLine[1]);
            dt.Columns.Add(splitLine[2]);
            dt.Columns.Add(splitLine[3]);
            dt.Columns.Add(splitLine[4]);

            for(int i = 1; i < splitContent.Length; i++)
            {
                splitLine = splitContent[i].Split(',');

                dt.Rows.Add(splitLine);
            }

            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char l = (char)comboBox1.SelectedItem;

            dt.Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();

            string content = File.ReadAllText(openFileDialog1.FileName);

            string[] splitContent = content.Split('\n');

            string[] splitLine = splitContent[0].Split(',');

            dt.Columns.Add(splitLine[0]);
            dt.Columns.Add(splitLine[1]);
            dt.Columns.Add(splitLine[2]);
            dt.Columns.Add(splitLine[3]);
            dt.Columns.Add(splitLine[4]);

            for (int i = 1; i < splitContent.Length; i++)
            {
                splitLine = splitContent[i].Split(',');

                if (splitLine[2][0] == l)
                {
                    dt.Rows.Add(splitLine);
                }
                
            }

            dataGridView1.DataSource = dt;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();

            secondForm.Show();
        }

    }

}
